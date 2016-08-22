using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTimer
{
    public partial class WindowTimer : Form
    {
        private static readonly TimeSpan INACTIVITY_DELAY = new TimeSpan( 0, 0, 10 );

        private readonly NotifyIcon _notifyIcon = new NotifyIcon();

        private readonly ActivityLog _log = new ActivityLog();

        private IKeyboardMouseEvents _globalHook;
        private bool _monitoring = true;

        private DateTime _lastActivity = DateTime.Now;
        private bool _active = true;
        private bool _locked = false;

        private DateTime _windowActivatedTime;
        private String _currentWindow;


        public WindowTimer()
        {
            InitializeComponent();

            InitializeHandlers();
            InitializeNotifyIcon();
        }

        private void InitializeHandlers()
        {
            this.Shown += ( sender, e ) => uxTimer.Start();
            this.Resize += ( sender, e ) => HandleResize();
            this.FormClosing += HandleFormClosing;

            uxTimer.Tick += ( sender, e ) => this.Monitor();

            uxPauseResumeMonitor.Click += ( sender, e ) => this.PauseResumeMonitor();

            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyPress += ( sender, e ) => LogUserActivity();
            _globalHook.MouseMove += ( sender, e ) => LogUserActivity();

            SystemEvents.SessionSwitch += HandleSessionSwitch;
        }

        private void InitializeNotifyIcon()
        {
            _notifyIcon.DoubleClick += ( sender, e ) => this.ShowFromSystemTray();

            _notifyIcon.Text = this.Text;
            _notifyIcon.Icon = this.Icon;
            _notifyIcon.Visible = true;

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add( "Exit" ).Click += ( sender, e ) => Application.Exit();

            _notifyIcon.ContextMenu = menu;
        }

        private void HandleFormClosing( Object sender, FormClosingEventArgs e )
        {
            if( e.CloseReason == CloseReason.UserClosing )
            {
                e.Cancel = true;
                this.MinimizeToSystemTray();
            }
        }

        private void HandleSessionSwitch( Object sender, SessionSwitchEventArgs e )
        {
            if( e.Reason == SessionSwitchReason.SessionLock )
            {
                _locked = true;
                EndCurrentWindowLog( DateTime.Now, null );
                _log.AddEntry( "LOCK", DateTime.Now, DateTime.Now );
            }
            else if( e.Reason == SessionSwitchReason.SessionUnlock )
            {
                _locked = false;
                _log.AddEntry( "UNLOCK", DateTime.Now, DateTime.Now );
            }
        }

        private void HandleResize()
        {
            if( this.WindowState == FormWindowState.Minimized )
            {
                this.MinimizeToSystemTray();
            }
        }

        private void MinimizeToSystemTray()
        {
            this.Hide();
        }

        private void ShowFromSystemTray()
        {
            if( !this.Visible )
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Activate();
            }
        }

        private void LogUserActivity()
        {
            if( !_monitoring || _locked )
            {
                return;
            }

            _lastActivity = DateTime.Now;

            Monitor();
        }

        private void Monitor()
        {
            if( _locked )
            {
                return;
            }
            DateTime now = DateTime.Now;

            String foregroundWindow = Native.GetForegroundWindowTitle();

            uxForegroundWindow.Text = foregroundWindow;

            if( _monitoring )
            {

                if( foregroundWindow != null && !foregroundWindow.Equals( _currentWindow ) )
                {
                    EndCurrentWindowLog( now, foregroundWindow );
                }

                if( now - _lastActivity > INACTIVITY_DELAY )
                {
                    uxForegroundWindow.Text = "[INACTIVE] " + uxForegroundWindow.Text;

                    if( _active )
                    {
                        _active = false;
                        EndCurrentWindowLog( now, null );
                    }
                }
            }
        }

        private void EndCurrentWindowLog( DateTime now, String newForegroundWindow )
        {
            if( _currentWindow != null )
            {
                _log.AddEntry( _currentWindow, _windowActivatedTime, now );
                uxActivityLog.Items.Clear();
                uxActivityLog.Items.AddRange( _log.Reverse().ToArray() );
            }

            _windowActivatedTime = now;
            _currentWindow = newForegroundWindow;
        }

        private void PauseResumeMonitor()
        {
            if( _monitoring )
            {
                _monitoring = false;
                EndCurrentWindowLog( DateTime.Now, null );
            }
            else
            {
                _monitoring = true;
                LogUserActivity();
            }
        }
    }
}
