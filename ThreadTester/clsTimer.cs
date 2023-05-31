﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTester
        // Interval in ms
        int mintIntervalIn_ms;


        // thread for timer timing
        Thread mobjThreadOne;


        // Thread stop
        bool mblStop;


        // definition of event form
        public delegate void dlgTick();
        // Declaration of event
        public event dlgTick Tick;

        // Form where my obj exists
        public Form mobjForm;


        //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//
        // Interval of timer tick
        //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//
        public int Interval
        {
            get { return mintIntervalIn_ms; }
            set { mintIntervalIn_ms = value;  }
        }


        //-----------------------------------------------------------
        // Timer constructor
        //-----------------------------------------------------------
        public clsTimer(int intInterval)


        //-----------------------------------------------------------
        // Timer start
        //-----------------------------------------------------------
        public bool Start()
            //              !Don't start it before stoping the thread!

            //
            mblStop = false;
            mobjThreadOne.Start();

        //-----------------------------------------------------------
        // Thread timeru
        //-----------------------------------------------------------

        private void MyRoutine()
        {
            do
            {
                // call of events in form thread
                if(mobjForm!=null)
                    mobjForm.Invoke(Tick);
                // Tick();

                // will make thread asleep Zzzzzz
                //Thread.Sleep(mintIntervalIn_ms);
                do 
                { 
                    DateTime.Ticks   //TODO: microsecs
                } while ();
                
            } while (mblStop == false);
        }

        //-----------------------------------------------------------
        // Timer stop
        //-----------------------------------------------------------
        public bool Stop()
            mobjForm = null;
            // Stop thread
            mblStop = true;