using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake : Form
    {
        int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, back = 0;
        Piece [] snake = new  Piece [1250];
        List<int> available = new List<int>();
        bool[,] visit;

        Random rand = new Random();

        Timer timer = new Timer();


           }

    public snake()
    {
        InitalizeComponent();
        intial();
        LaunchTimer();
    }

    private void LaunchTimer()
    {
        timer.Interval = 50;
        timer.Tick += move;
        timer.Start();
    }

    private void snake_Keydown(object sender, KeyEventArgs e)
    {
        dx = dy = 0;
        switch(e.KeyCode)
        {
            
        }
    }
}