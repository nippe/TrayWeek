﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TrayWeek.GUI
{
    public class TrayWeekApplicationContext : ApplicationContext
    {
        private NotifyIcon _notifyIcon;
        private IContainer _components;
        private Timer _timer;
        private ContextMenuStrip _contextMenu; 


        public TrayWeekApplicationContext()
        {
            _components = new Container();
            _notifyIcon = new NotifyIcon(_components);

            _notifyIcon.Visible = true;
            
            UpdateUi();

            //Set timer to redraw
            _timer = new Timer();
            _timer.Elapsed +=TimerElapsed;
            _timer.Interval = 60*60*1000; //Hourly update
            _timer.Enabled = true;
            _timer.Start();

            //Initialize context menu
            InitContextMenu();
        }

        private void InitContextMenu()
        {
            //Add Exit menu item
            _contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem_Exit = new ToolStripMenuItem("Exit", null, new EventHandler(this.menuItem_Exit_Click));
            _contextMenu.Items.Add(menuItem_Exit);
            _notifyIcon.ContextMenuStrip = _contextMenu;
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateUi();
        }

private void UpdateUi()
{
    Graphics graphics;
    Font font;

    Image image = TrayWeekResources.date;

    using (graphics = Graphics.FromImage(image))
    {
        int weekNo = DateHelper.GetCurrentWeekNumber(DateTime.Now);
                
        font = new Font("Lucida Console", 18, FontStyle.Regular);
        SizeF size = graphics.MeasureString(weekNo.ToString(), font);
        Point startingPoint = CalculateStartingPoint(size);

        graphics.DrawString(weekNo.ToString(), font, Brushes.GhostWhite, startingPoint);

        SetBaloonTip(weekNo);

        _notifyIcon.Icon = ImageToIcon(image);
    }
}

        private void SetBaloonTip(int weekNo)
        {
            _notifyIcon.Text = String.Format("{0}: {1}", TrayWeekResources.ResourceManager.GetString("week"),
                                                       weekNo.ToString());
        }


        public Point CalculateStartingPoint(SizeF size)
        {
            float x = 32/2 - size.Width/2;
            float y = 32/2 - size.Height/2;

            return new Point((int)x, (int)y);
        }


        private Icon ImageToIcon(Image image)
        {
            return Icon.FromHandle(((Bitmap) image).GetHicon());
        }
    }
}