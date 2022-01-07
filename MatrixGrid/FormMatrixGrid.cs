using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MatrixGrid
{
    public partial class FormMatrixGrid : Form
    {
        public int m_width;
        public int m_Height;
        public int m_NoOfRows;
        public int m_NoOfCols;
        public int m_XOffset;
        public int m_YOffset;
        public int count1;
        public int count2;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 1;
        public const int DEFAULT_NO_COLS = 1;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;

        public FormMatrixGrid()
        {
            Initialize();
            InitializeComponent();
            bThreadStatus = false;
        }

     
     


        public void Initialize()
        {
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;
        }

        private void DrawGrid()
        {
            

                try
                {

                    Graphics boardLayout = this.CreateGraphics();
                    Pen layoutPen = new Pen(Color.Blue);
                    layoutPen.Width = 3;

                    int X = DEFAULT_X_OFFSET;
                    int Y = DEFAULT_Y_OFFSET;

                    for (int i = 0; i <= m_NoOfRows; i++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.m_NoOfCols, Y);
                        Y = Y + m_Height;
                    }


                    X = DEFAULT_X_OFFSET;
                    Y = DEFAULT_Y_OFFSET;
                    for (int j = 0; j <= m_NoOfCols; j++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_NoOfRows);
                        X = X + this.m_width;
                    }
                //    if(count1==count2)
                //{
                //    count1 = 0;
                //    count2 = 0;
                //}
               
                }
         
               
            catch (Exception e)
                { }

          
        }
        private void Counter()
        {
            //Graphics g;
            count1 = 0;
            m_NoOfCols = 0;
            m_NoOfRows = 0;
            while (count1 < count2)
                {

                    DrawGrid();
                    m_NoOfRows++;
                    m_NoOfCols++;
                count1++;
                Thread.Sleep(1000);

                //if(count1==count2)
                //{
                //    break;
                //}
                }
         

            //CounterThread = new Thread(new ThreadStart(Counter));

            this.Invalidate();

            //m_NoOfRows = count2;
            //m_NoOfCols = count2;
            //g.Clear(Color.Blue);

            //Thread.Sleep(1000);
        }


  
        private void OnPaint(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            CounterThread = new Thread(new ThreadStart(Counter));
            CounterThread.Start();
            bThreadStatus = true;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //count1=0;
            count2 = 4;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            //count1 = 0;
            count2 = 5;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            count2 = 6;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
            count2 = 7;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            
            count2 = 8;


        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

           
            count2 = 9;
   
            }
       
      
    }
        
    }

