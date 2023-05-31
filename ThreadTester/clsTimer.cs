using System;using System.Collections.Generic;using System.Linq;using System.Runtime.CompilerServices;
using System.Text;using System.Threading;
using System.Threading.Tasks;using System.Windows.Forms;

namespace ThreadTester{    internal class clsTimer    {
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
        public clsTimer(int intInterval)        {            mintIntervalIn_ms = Math.Abs(intInterval);            mobjForm = null;        }


        //-----------------------------------------------------------
        // Timer start
        //-----------------------------------------------------------
        public bool Start()        {            // Creation of thread   (Not in constructor because after stop it wouldn't start up)
            //              !Don't start it before stoping the thread!            mobjThreadOne = new Thread(MyRoutine);

            //
            mblStop = false;
            mobjThreadOne.Start();            return true;        }

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
        public bool Stop()        {
            mobjForm = null;
            // Stop thread
            mblStop = true;            return true;        }    }}