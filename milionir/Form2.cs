using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace milionir
{
    public partial class Form2 : Form
    {      //timer1  //timer2   //timer3  //timer4
        int c = 29 ,   s=3 ,     d=2      , m=3;
             //help    //button
        bool x = true, y = true,retrn=true, notavilable=true, clickbutton1 = false, clickbutton2 = false, clickbutton3 = false, clickbutton4 = false;
       //بسم الله الرحمن الرحيم
        int questioncounter = 2 , answercounter = 4;
        string answer;
        //map 1 for question And Correct Answer 
        Dictionary <int , List<string>> map1=new Dictionary<int,List<string>>();
        List<string> vector1 = new List<string>();
        // map2 For All Answer
        Dictionary<int, List<string>> map2 = new Dictionary<int, List<string>>();
        List<string> vector2 = new List<string>();

        
        public Form2()
        {
            InitializeComponent();
            using (StreamReader read1 = new StreamReader(@"F:\New folder (2)\milionir\Question.txt", Encoding.Default))
            {
                string text;
                while (!read1.EndOfStream)
                {
                    text = read1.ReadLine();
                    vector1.Add(text);
                }
                Question.ButtonText = vector1[0];
                answer = vector1[1];
            }
            using (StreamReader read = new StreamReader(@"F:\New folder (2)\milionir\Answer.txt", Encoding.Default))
            {
                string txt;
                while (!read.EndOfStream)
                {
                    txt = read.ReadLine();
                    vector2.Add(txt);
                }
                FirstAnswer.ButtonText = vector2[0];
                SecondAnswer.ButtonText = vector2[1];
                ThirdAnswer.ButtonText = vector2[2];
                FourthAnsweer.ButtonText = vector2[3];
            }
            timer1.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (x)
            {
                    if (notavilable)
                    {
                        pictureBox9.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\people.jpg");
                        if (FirstAnswer.ButtonText == answer)
                        {
                            Form3 obj = new Form3();
                            obj.Show();
                        }
                        else if (SecondAnswer.ButtonText == answer)
                        {
                            Form6 obj = new Form6();
                            obj.Show();
                        }
                        else if (ThirdAnswer.ButtonText == answer)
                        {
                            Form7 obj = new Form7();
                            obj.Show();
                        }
                        else
                        {
                            Form8 obj = new Form8();
                            obj.Show();
                        }
                        notavilable = false;
                    } 
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (x)
            {
                if (retrn)
                {
                    pictureBox7.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\phone.jpg");
                    if (FirstAnswer.ButtonText == answer)
                    {
                        Form5 obj = new Form5("( أ )");
                        obj.Show();
                    }
                    else if (SecondAnswer.ButtonText == answer)
                    {
                        Form5 obj = new Form5("( ب )");
                        obj.Show();
                    }
                    else if (ThirdAnswer.ButtonText == answer)
                    {
                        Form5 obj = new Form5("( ج )");
                        obj.Show();
                    }
                    else
                    {
                        Form5 obj = new Form5("( د )");
                        obj.Show();
                    }
                    retrn = false;
                } 
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (x)
            {
                pictureBox8.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\fifty.jpg");
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (x)
            {
                if (DialogResult.Yes == MessageBox.Show("هل أنت متأكد أنك تريد الإنسحاب ؟", "الانسحاب", MessageBoxButtons.YesNo))
                {
                    timer1.Stop();
                    this.Hide();
                    Form4 objct = new Form4();
                    objct.Show();
                }
            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c--;
            label1.Text = c.ToString();
            if (c == -1)
            {
                timer1.Stop();
                Form4 g = new Form4();
                this.Hide();
                g.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void FirstAnswer_Click(object sender, EventArgs e)
        {

        }
        int Score = 0;
        bool answer1 = false,answer2=false,answer3=false,answer4=false;
        private void SecondAnswer_Click(object sender, EventArgs e)
        {
            if (y == true)
            {
                SecondAnswer.IdleFillColor = Color.Orange;
                SecondAnswer.ActiveFillColor = Color.Orange;
                if (SecondAnswer.ButtonText == answer)
                    answer2 = true;
                else
                    clickbutton2 = true;
                timer2.Start();
                timer1.Stop();
                x = false;
                y = false;
            }
        }

        private void FirstAnswer_Click_1(object sender, EventArgs e)
        {
            if (y==true)
            {
                FirstAnswer.IdleFillColor = Color.Orange;
                FirstAnswer.ActiveFillColor = Color.Orange;
                if (FirstAnswer.ButtonText == answer)
                    answer1 = true;
                else
                    clickbutton1 = true;
                timer2.Start();   
                timer1.Stop();
                x = false;
                y = false;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void ThirdAnswer_Click(object sender, EventArgs e)
        {
            if (y == true)
            {
                ThirdAnswer.IdleFillColor = Color.Orange;
                ThirdAnswer.ActiveFillColor = Color.Orange;
                if (ThirdAnswer.ButtonText == answer)
                    answer3 = true;
                else
                    clickbutton3 = true;
                timer2.Start();
                timer1.Stop();
                x = false;
                y = false;
            }
        }


        private void FourthAnsweer_Click(object sender, EventArgs e)
        {
            if (y == true)
            {
                FourthAnsweer.IdleFillColor = Color.Orange;
                FourthAnsweer.ActiveFillColor = Color.Orange;
                if (FourthAnsweer.ButtonText == answer)
                    answer4 = true;
                else
                    clickbutton4 = true;
                timer2.Start();
                timer1.Stop();
                x = false;
                y = false;
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
////////////////////////////////////////////check/////////////////////////////////////////////////////////
        private void timer2_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                timer2.Stop();
           //////////////////////////////////button 1 //////////////////////////////////////////////////////
                if (answer1==true)
                {
                    FirstAnswer.IdleFillColor = Color.Lime;
                    FirstAnswer.ActiveFillColor = Color.Lime;
                    Score++;
                    timer3.Start();
                    answer1 = false;
                }
                else if (answer2 == true)
                {
                    SecondAnswer.IdleFillColor = Color.Lime;
                    SecondAnswer.ActiveFillColor = Color.Lime;
                    Score++;
                    timer3.Start();
                    answer2 = false;
                }
                else if (answer3 == true)
                {
                    ThirdAnswer.IdleFillColor = Color.Lime;
                    ThirdAnswer.ActiveFillColor = Color.Lime;
                    Score++;
                    timer3.Start();
                    answer3 = false;
                }
                else if (answer4 == true)
                {
                    FourthAnsweer.IdleFillColor = Color.Lime;
                    FourthAnsweer.ActiveFillColor = Color.Lime;
                    Score++;
                    timer3.Start();
                    answer4 = false;
                }
    ////////////////////////////////////////////////////////////////////////button1 ////////////////////////////////////
                else if (clickbutton1==true)
                {
                        if (SecondAnswer.ButtonText == answer)
                        {
                            FirstAnswer.IdleFillColor = Color.Red;
                            FirstAnswer.ActiveFillColor = Color.Red;

                            SecondAnswer.IdleFillColor = Color.Lime;
                            SecondAnswer.ActiveFillColor = Color.Lime;
                        }
                        else if (ThirdAnswer.ButtonText == answer)
                        {
                            FirstAnswer.IdleFillColor = Color.Red;
                            FirstAnswer.ActiveFillColor = Color.Red;

                            ThirdAnswer.IdleFillColor = Color.Lime;
                            ThirdAnswer.ActiveFillColor = Color.Lime;
                        }

                        else if (FourthAnsweer.ButtonText == answer)
                        {
                            FirstAnswer.IdleFillColor = Color.Red;
                            FirstAnswer.ActiveFillColor = Color.Red;

                            FourthAnsweer.IdleFillColor = Color.Lime;
                            FourthAnsweer.ActiveFillColor = Color.Lime;
                        }
                        timer4.Start();
                        clickbutton1 = false;
                }
/////////////////////////////////////////////////////////////////button 2 //////////////////////////////////////
                   
                    else if(clickbutton2==true)
                    {
                            if (FirstAnswer.ButtonText == answer)
                            {
                                SecondAnswer.IdleFillColor = Color.Red;
                                SecondAnswer.ActiveFillColor = Color.Red;

                                FirstAnswer.IdleFillColor = Color.Lime;
                                FirstAnswer.ActiveFillColor = Color.Lime;
                            }

                            else if (ThirdAnswer.ButtonText == answer)
                            {
                                SecondAnswer.IdleFillColor = Color.Red;
                                SecondAnswer.ActiveFillColor = Color.Red;

                                ThirdAnswer.IdleFillColor = Color.Lime;
                                ThirdAnswer.ActiveFillColor = Color.Lime;
                            }

                            else if (FourthAnsweer.ButtonText == answer)
                            {
                                SecondAnswer.IdleFillColor = Color.Red;
                                SecondAnswer.ActiveFillColor = Color.Red;

                                FourthAnsweer.IdleFillColor = Color.Lime;
                                FourthAnsweer.ActiveFillColor = Color.Lime;
                            }
                            timer4.Start();
                            clickbutton2 = false;
                    }
              ///////////////////////////////button3////////////////////////////////////////////////////
                   
                    else if(clickbutton3==true)
                    {
                            if (FirstAnswer.ButtonText == answer)
                            {
                                ThirdAnswer.IdleFillColor = Color.Red;
                                ThirdAnswer.ActiveFillColor = Color.Red;

                                FirstAnswer.IdleFillColor = Color.Lime;
                                FirstAnswer.ActiveFillColor = Color.Lime;

                            }

                            else if (SecondAnswer.ButtonText == answer)
                            {
                                ThirdAnswer.IdleFillColor = Color.Red;
                                ThirdAnswer.ActiveFillColor = Color.Red;

                                SecondAnswer.IdleFillColor = Color.Lime;
                                SecondAnswer.ActiveFillColor = Color.Lime;
                            }

                            else if (FourthAnsweer.ButtonText == answer)
                            {
                                ThirdAnswer.IdleFillColor = Color.Red;
                                ThirdAnswer.ActiveFillColor = Color.Red;

                                FourthAnsweer.IdleFillColor = Color.Lime;
                                FourthAnsweer.ActiveFillColor = Color.Lime;
                            }
                            timer4.Start();
                            clickbutton3 = false;
                    }
        /////////////////////button4//////////////////////////////////////////////////////
                    
                
                    else if(clickbutton4==true)
                    {
                            if (FirstAnswer.ButtonText == answer)
                            {

                                FourthAnsweer.IdleFillColor = Color.Red;
                                FourthAnsweer.ActiveFillColor = Color.Red;

                                FirstAnswer.IdleFillColor = Color.Lime;
                                FirstAnswer.ActiveFillColor = Color.Lime;

                            }

                            else if (SecondAnswer.ButtonText == answer)
                            {
                                FourthAnsweer.IdleFillColor = Color.Red;
                                FourthAnsweer.ActiveFillColor = Color.Red;

                                SecondAnswer.IdleFillColor = Color.Lime;
                                SecondAnswer.ActiveFillColor = Color.Lime;
                            }

                            else if (ThirdAnswer.ButtonText == answer)
                            {
                                FourthAnsweer.IdleFillColor = Color.Red;
                                FourthAnsweer.ActiveFillColor = Color.Red;

                                ThirdAnswer.IdleFillColor = Color.Lime;
                                ThirdAnswer.ActiveFillColor = Color.Lime;
                            }
                            timer4.Start();
                            clickbutton4 = false;
                        }
                }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            d--;
            if (d == -1)
            {
                if (Score == 1)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score1.png");

                else if (Score == 2)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score2.png");

                else if (Score == 3)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score3.png");
                else if (Score == 4)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score4.png");
                else if (Score == 5)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score5.png");
                else if (Score == 6)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score6.png");
                else if (Score == 7)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score7.png");
                else if (Score == 8)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score8.png");
                else if (Score == 9)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score9.png");
                else if (Score == 10)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score10.png");
                else if (Score == 11)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score11.png");
                else if (Score == 12)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score12.png");
                else if (Score == 13)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score13.png");
                else if (Score == 14)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score14.png");
                else if (Score == 15)
                    Score_0.Image = Image.FromFile(@"C:\Users\ashraf-pc\Desktop\Millionair_Images\Score15.png");
                
                if (Score != 16)
                {
                        FirstAnswer.IdleFillColor = Color.Black;
                        FirstAnswer.ActiveFillColor = Color.Black;
                     
                        SecondAnswer.IdleFillColor = Color.Black;
                        SecondAnswer.ActiveFillColor = Color.Black;
    
                        ThirdAnswer.IdleFillColor = Color.Black;
                        ThirdAnswer.ActiveFillColor = Color.Black;
           
                        FourthAnsweer.IdleFillColor = Color.Black;
                        FourthAnsweer.ActiveFillColor = Color.Black;

                    c = 30;
                    s = 3;
                    d = 1;
                    timer1.Start();
                    timer3.Stop();
                    y = true;
                    x = true;

                    Question.ButtonText = vector1[questioncounter];
                    answer = vector1[questioncounter + 1];
                    FirstAnswer.ButtonText = vector2[answercounter];
                    SecondAnswer.ButtonText = vector2[answercounter + 1];
                    ThirdAnswer.ButtonText = vector2[answercounter + 2];
                    FourthAnsweer.ButtonText = vector2[answercounter + 3];
                    questioncounter += 2;
                    answercounter += 4;
                }
                else
                {
                    timer3.Stop();
                    Form11 obj =new Form11();
                    obj.Show();
                    this.Close();
                }
            }
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }


        private void timer4_Tick_1(object sender, EventArgs e)
        {
            m--;
            if (m == -1)
            {
                timer4.Stop();
                if (Score >= 0 && Score <= 4)
                {
                    Form4 obj = new Form4();
                    obj.Show();
                    this.Close();
                }
                else if (Score >= 5 && Score <= 9)
                {
                    Form9 obj = new Form9();
                    obj.Show();
                    this.Close();
                }
                else if (Score >= 10 && Score <= 15)
                {
                    Form10 obj = new Form10();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    Form11 obj = new Form11();
                    obj.Show();
                    this.Close();
                }
            }
        }
    }
}
