using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "Kalkulator Kuby R", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        double liczba1 = 0, liczba2 = 0, wynik = 0;
        //double liczbaD1 = 0, liczbaD2 = 0, wynikD = 0;
        string liczbaA = "", liczbaB = "";
        char znak='@';
        char wynikowyKontroler = ' ';
        char przecinek = ' ';

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button button0 = FindViewById<Button>(Resource.Id.button0);
            Button buttonPoint = FindViewById<Button>(Resource.Id.buttonPoint);
            Button buttonPlus = FindViewById<Button>(Resource.Id.buttonPlus);
            Button buttonMinus = FindViewById<Button>(Resource.Id.buttonMinus);
            Button buttonMultiplication = FindViewById<Button>(Resource.Id.buttonMultiplication);
            Button buttonDivision = FindViewById<Button>(Resource.Id.buttonDivision);
            Button buttonEqual = FindViewById<Button>(Resource.Id.buttonEqual);
            Button buttonC = FindViewById<Button>(Resource.Id.buttonC);
            Button buttonPow = FindViewById<Button>(Resource.Id.buttonPow);
            Button buttonSqr = FindViewById<Button>(Resource.Id.buttonSqr);

            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);

            button1.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "1";
                if(znak=='@')
                {
                    liczbaA += "1";
                    if (przecinek == '.')
                        liczbaA += ".";
                }
                else
                {
                    liczbaB += "1";
                    if (przecinek == '.')
                        liczbaB += ".";
                }
                
                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button2.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "2";
                if (znak == '@')
                {
                    liczbaA += "2";
                }
                else
                {
                    liczbaB += "2";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button3.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "3";
                if (znak == '@')
                {
                    liczbaA += "3";
                }
                else
                {
                    liczbaB += "3";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button4.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "4";
                if (znak == '@')
                {
                    liczbaA += "4";
                }
                else
                {
                    liczbaB += "4";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button5.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "5";
                if (znak == '@')
                {
                    liczbaA += "5";
                }
                else
                {
                    liczbaB += "5";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button6.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "6";
                if (znak == '@')
                {
                    liczbaA += "6";
                }
                else
                {
                    liczbaB += "6";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button7.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "7";
                if (znak == '@')
                {
                    liczbaA += "7";
                }
                else
                {
                    liczbaB += "7";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button8.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "8";
                if (znak == '@')
                {
                    liczbaA += "8";
                }
                else
                {
                    liczbaB += "8";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button9.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "9";
                if (znak == '@')
                {
                    liczbaA += "9";
                }
                else
                {
                    liczbaB += "9";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1/liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            button0.Click += delegate {
                if (znak == '@' && wynikowyKontroler == '=')
                {
                    textView1.Text = "";
                    wynikowyKontroler = ' ';
                }
                textView1.Text += "0";
                if (znak == '@')
                {
                    liczbaA += "0";
                }
                else
                {
                    liczbaB += "0";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    case '^':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, liczba2);
                        break;
                    case 'p':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = Math.Pow(liczba1, 1 / liczba2);
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };




            buttonPoint.Click += delegate {
                textView1.Text += ".";
                if (znak == '@')
                {
                    liczbaA += ".";
                }
                else
                {
                    liczbaB += ".";
                }

                switch (znak)
                {
                    case '+':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 + liczba2;
                        break;
                    case '-':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 - liczba2;
                        break;
                    case 'x':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 * liczba2;
                        break;
                    case '/':
                        Double.TryParse(liczbaB, out liczba2);
                        wynik = liczba1 / liczba2;
                        break;
                    default:
                        Double.TryParse(liczbaA, out liczba1);
                        break;
                }
            };

            buttonPlus.Click += delegate {
                textView1.Text += "+";
                znak = '+';
            };

            buttonMinus.Click += delegate {
                textView1.Text += "-";
                znak = '-';
            };

            buttonMultiplication.Click += delegate {
                textView1.Text += "x";
                znak = 'x';
            };

            buttonDivision.Click += delegate {
                textView1.Text += "/";
                znak = '/';
            };

            buttonPow.Click += delegate {
                textView1.Text += "^";
                znak = '^';
            };

            buttonSqr.Click += delegate {
                textView1.Text += " sqr";
                znak = 'p';
            };

            buttonEqual.Click += delegate {
                textView1.Text = "";
                textView1.Text += string.Format("{0}", wynik);
                znak = '@';
                liczba1 = wynik;
                liczbaA = "";
                liczbaB = "";
                wynikowyKontroler = '=';
            };

            buttonC.Click += delegate {
                textView1.Text = "0";
                znak = '@';
                wynikowyKontroler = '=';
                liczbaA = "";
                liczbaB = "";
            };
        }
    }
}

