﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesFormsApp
{
    public class MoveBall : RandomPointAndSizeBall
    {
        private System.Windows.Forms.Timer timer;
        public MoveBall(MainForm form) : base(form)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
      
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop() 
        { 
            timer.Stop(); 
        }



    }
}
