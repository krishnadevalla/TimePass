using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace change
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        Timer myTimer = new Timer();
        int speed = 0;
        public MainWindow()
        {

            InitializeComponent();
        }
        public  void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                change1();
                change2();
                change3();
                change4();
                change5();
                change6();
                change7();
                change8();
                change9();
                change10();
                change11();
                change12();
                change13();
                change14();
                change15();
                change16();
                change17();
                change18();
                change19();
                change20();
                change21();
                change22();
                change23();
                change24();
                change25();
                change26();
                change27();
                change28();
                change29();
                change30();
                change31();
                change32();
                change33();
                change34();
                change35();
                change36();
                change37();
                change38();
                change39();
                change40();
                change41();
                change42();
                change43();
                change44();
                change45();
                change46();
                change47();
                change48();
                change49();
                change50();
                change51();
                change52();
                change53();
                change54();
                change55();
                change56();
                change57();
                change58();
                change59();
                change60();
                change61();
                change62();
                change63();
                change64();
                change65();
                change66();
                change67();
                change68();
                change69();
                change70();
                change71();
                change72();
                change73();
                change74();
                change75();
                change76();
                change77();
                change78();
                change79();
                change80();
                change81();
                change82();
                change83();
                change84();
                change85();
                change86();
                change87();
                change88();
                change89();
                change90();
                change91();
                change1_Copy();
                change2_Copy();
                change3_Copy();
                change4_Copy();
                change5_Copy();
                change6_Copy();
                change7_Copy();
                change8_Copy();
                change9_Copy();
                change10_Copy();
                change11_Copy();
                change12_Copy();
                change13_Copy();
                change14_Copy();
                change15_Copy();
                change16_Copy();
                change17_Copy();
                change18_Copy();
                change19_Copy();
                change20_Copy();
                change21_Copy();
                change22_Copy();
                change23_Copy();
                change24_Copy();
                change25_Copy();
                change26_Copy();
                change27_Copy();
                change28_Copy();
                change29_Copy();
                change30_Copy();
                change31_Copy();
                change32_Copy();
                change33_Copy();
                change34_Copy();
                change35_Copy();
                change36_Copy();
                change37_Copy();
                change38_Copy();
                change39_Copy();
                change40_Copy();
                change41_Copy();
                change42_Copy();
                change43_Copy();
                change44_Copy();
                change45_Copy();
                change46_Copy();
                change47_Copy();
                change48_Copy();
                change49_Copy();
                change50_Copy();
                change51_Copy();
                change52_Copy();
                change53_Copy();
                change54_Copy();
                change55_Copy();
                change56_Copy();
                change57_Copy();
                change58_Copy();
                change59_Copy();
                change60_Copy();
                change61_Copy();
                change62_Copy();
                change63_Copy();
                change64_Copy();
                change65_Copy();
                change66_Copy();
                change67_Copy();
                change68_Copy();
                change69_Copy();
                change70_Copy();
                change71_Copy();
                change72_Copy();
                change73_Copy();
                change74_Copy();
                change75_Copy();
                change76_Copy();
                change77_Copy();
                change78_Copy();
                change79_Copy();
                change80_Copy();
                change81_Copy();
                change82_Copy();
                change83_Copy();
                change84_Copy();
                change85_Copy();
                change86_Copy();
                change87_Copy();
                change88_Copy();
                change89_Copy();
                change90_Copy();
                change91_Copy();
                change1_Copy1();
                change2_Copy1();
                change3_Copy1();
                change4_Copy1();
                change5_Copy1();
                change6_Copy1();
                change7_Copy1();
                change8_Copy1();
                change9_Copy1();
                change10_Copy1();
                change11_Copy1();
                change12_Copy1();
                change13_Copy1();
                change14_Copy1();
                change15_Copy1();
                change16_Copy1();
                change17_Copy1();
                change18_Copy1();
                change19_Copy1();
                change20_Copy1();
                change21_Copy1();
                change22_Copy1();
                change23_Copy1();
                change24_Copy1();
                change25_Copy1();
                change26_Copy1();
                change27_Copy1();
                change28_Copy1();
                change29_Copy1();
                change30_Copy1();
                change31_Copy1();
                change32_Copy1();
                change33_Copy1();
                change34_Copy1();
                change35_Copy1();
                change36_Copy1();
                change37_Copy1();
                change38_Copy1();
                change39_Copy1();
                change40_Copy1();
                change41_Copy1();
                change42_Copy1();
                change43_Copy1();
                change44_Copy1();
                change45_Copy1();
                change46_Copy1();
                change47_Copy1();
                change48_Copy1();
                change49_Copy1();
                change50_Copy1();
                change51_Copy1();
                change52_Copy1();
                change53_Copy1();
                change54_Copy1();
                change55_Copy1();
                change56_Copy1();
                change57_Copy1();
                change58_Copy1();
                change59_Copy1();
                change60_Copy1();
                change61_Copy1();
                change62_Copy1();
                change63_Copy1();
                change64_Copy1();
                change65_Copy1();
                change66_Copy1();
                change67_Copy1();
                change68_Copy1();
                change69_Copy1();
                change70_Copy1();
                change71_Copy1();
                change72_Copy1();
                change73_Copy1();
                change74_Copy1();
                change75_Copy1();
                change76_Copy1();
                change77_Copy1();
                change78_Copy1();
                change79_Copy1();
                change80_Copy1();
                change81_Copy1();
                change82_Copy1();
                change83_Copy1();
                change84_Copy1();
                change85_Copy1();
                change86_Copy1();
                change87_Copy1();
                change88_Copy1();
                change89_Copy1();
                change90_Copy1();
                change91_Copy1();
                change1_Copy2();
                change2_Copy2();
                change3_Copy2();
                change4_Copy2();
                change5_Copy2();
                change6_Copy2();
                change7_Copy2();
                change8_Copy2();
                change9_Copy2();
                change10_Copy2();
                change11_Copy2();
                change12_Copy2();
                change13_Copy2();
                change14_Copy2();
                change15_Copy2();
                change16_Copy2();
                change17_Copy2();
                change18_Copy2();
                change19_Copy2();
                change20_Copy2();
                change21_Copy2();
                change22_Copy2();
                change23_Copy2();
                change24_Copy2();
                change25_Copy2();
                change26_Copy2();
                change27_Copy2();
                change28_Copy2();
                change29_Copy2();
                change30_Copy2();
                change31_Copy2();
                change32_Copy2();
                change33_Copy2();
                change34_Copy2();
                change35_Copy2();
                change36_Copy2();
                change37_Copy2();
                change38_Copy2();
                change39_Copy2();
                change40_Copy2();
                change41_Copy2();
                change42_Copy2();
                change43_Copy2();
                change44_Copy2();
                change45_Copy2();
                change46_Copy2();
                change47_Copy2();
                change48_Copy2();
                change49_Copy2();
                change50_Copy2();
                change51_Copy2();
                change52_Copy2();
                change53_Copy2();
                change54_Copy2();
                change55_Copy2();
                change56_Copy2();
                change57_Copy2();
                change58_Copy2();
                change59_Copy2();
                change60_Copy2();
                change61_Copy2();
                change62_Copy2();
                change63_Copy2();
                change64_Copy2();
                change65_Copy2();
                change66_Copy2();
                change67_Copy2();
                change68_Copy2();
                change69_Copy2();
                change70_Copy2();
                change71_Copy2();
                change72_Copy2();
                change73_Copy2();
                change74_Copy2();
                change75_Copy2();
                change76_Copy2();
                change77_Copy2();
                change78_Copy2();
                change79_Copy2();
                change80_Copy2();
                change81_Copy2();
                change82_Copy2();
                change83_Copy2();
                change84_Copy2();
                change85_Copy2();
                change86_Copy2();
                change87_Copy2();
                change88_Copy2();
                change89_Copy2();
                change90_Copy2();
                change91_Copy2();
            }));
        }
        void change1()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));
            
        }
        void change2()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change3()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g3.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change4()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g4.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change5()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g5.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change6()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g6.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change7()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g7.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change8()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g8.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change9()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g9.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change10()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g10.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change11()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g11.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change12()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g12.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change13()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g13.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change14()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g14.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change15()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g15.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change16()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g16.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change17()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g17.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change18()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g18.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change19()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g19.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change20()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g20.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change21()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g21.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change22()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g22.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change23()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g23.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change24()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g24.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change25()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g25.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change26()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g26.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change27()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g27.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change28()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g28.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change29()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g29.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change30()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g30.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change31()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g31.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change32()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g32.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change33()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g33.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change34()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g34.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change35()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g35.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change36()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g36.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change37()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g37.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change38()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g38.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change39()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g39.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change40()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g40.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change41()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g41.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change42()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g42.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change43()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g43.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change44()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g44.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change45()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g45.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change46()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g46.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change47()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g47.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change48()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g48.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change49()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g49.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change50()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g50.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change51()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g51.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change52()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g52.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change53()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g53.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change54()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g54.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change55()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g55.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change56()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g56.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change57()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g57.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change58()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g58.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change59()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g59.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change60()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g60.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change61()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g61.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change62()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g62.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change63()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g63.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change64()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g64.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change65()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g65.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change66()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g66.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change67()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g67.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change68()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g68.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change69()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g69.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change70()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g70.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change71()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g71.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change72()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g72.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change73()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g73.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change74()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g74.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change75()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g75.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change76()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g76.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change77()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g77.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change78()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g78.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change79()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g79.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change80()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g80.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change81()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g81.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change82()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g82.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change83()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g83.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change84()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g84.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change85()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g85.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change86()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g86.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change87()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g87.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change88()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g88.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change89()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g89.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change90()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g90.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change91()
        {
            byte a, b, c, d;
            
            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g91.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change1_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g1_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change2_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g2_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change3_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g3_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change4_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g4_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change5_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g5_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change6_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g6_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change7_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g7_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change8_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g8_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change9_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g9_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change10_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g10_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change11_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g11_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change12_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g12_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change13_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g13_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change14_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g14_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change15_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g15_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change16_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g16_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change17_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g17_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change18_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g18_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change19_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g19_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change20_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g20_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change21_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g21_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change22_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g22_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change23_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g23_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change24_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g24_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change25_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g25_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change26_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g26_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change27_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g27_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change28_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g28_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change29_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g29_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change30_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g30_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change31_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g31_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change32_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g32_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change33_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g33_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change34_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g34_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change35_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g35_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change36_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g36_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change37_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g37_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change38_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g38_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change39_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g39_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change40_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g40_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change41_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g41_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change42_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g42_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change43_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g43_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change44_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g44_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change45_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g45_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change46_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g46_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change47_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g47_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change48_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g48_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change49_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g49_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change50_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g50_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change51_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g51_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change52_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g52_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change53_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g53_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change54_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g54_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change55_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g55_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change56_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g56_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change57_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g57_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change58_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g58_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change59_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g59_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change60_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g60_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change61_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g61_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change62_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g62_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change63_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g63_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change64_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g64_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change65_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g65_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change66_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g66_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change67_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g67_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change68_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g68_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change69_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g69_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change70_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g70_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change71_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g71_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change72_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g72_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change73_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g73_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change74_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g74_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change75_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g75_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change76_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g76_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change77_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g77_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change78_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g78_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change79_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g79_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change80_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g80_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change81_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g81_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change82_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g82_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change83_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g83_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change84_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g84_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change85_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g85_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change86_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g86_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change87_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g87_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change88_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g88_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change89_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g89_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change90_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g90_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change91_Copy()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g91_Copy.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change1_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g1_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change2_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g2_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change3_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g3_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change4_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g4_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change5_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g5_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change6_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g6_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change7_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g7_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change8_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g8_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change9_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g9_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change10_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g10_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change11_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g11_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change12_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g12_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change13_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g13_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change14_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g14_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change15_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g15_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change16_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g16_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change17_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g17_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change18_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g18_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change19_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g19_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change20_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g20_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change21_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g21_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change22_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g22_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change23_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g23_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change24_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g24_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change25_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g25_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change26_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g26_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change27_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g27_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change28_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g28_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change29_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g29_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change30_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g30_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change31_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g31_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change32_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g32_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change33_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g33_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change34_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g34_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change35_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g35_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change36_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g36_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change37_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g37_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change38_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g38_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change39_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g39_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change40_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g40_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change41_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g41_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change42_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g42_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change43_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g43_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change44_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g44_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change45_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g45_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change46_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g46_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change47_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g47_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change48_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g48_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change49_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g49_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change50_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g50_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change51_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g51_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change52_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g52_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change53_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g53_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change54_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g54_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change55_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g55_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change56_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g56_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change57_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g57_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change58_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g58_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change59_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g59_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change60_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g60_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change61_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g61_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change62_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g62_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change63_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g63_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change64_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g64_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change65_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g65_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change66_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g66_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change67_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g67_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change68_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g68_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change69_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g69_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change70_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g70_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change71_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g71_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change72_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g72_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change73_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g73_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change74_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g74_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change75_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g75_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change76_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g76_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change77_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g77_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change78_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g78_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change79_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g79_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change80_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g80_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change81_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g81_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change82_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g82_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change83_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g83_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change84_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g84_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change85_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g85_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change86_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g86_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change87_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g87_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change88_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g88_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change89_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g89_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change90_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g90_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change91_Copy1()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g91_Copy1.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change1_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g1_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change2_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g2_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change3_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g3_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change4_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g4_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change5_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g5_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change6_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g6_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change7_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g7_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change8_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g8_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change9_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g9_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change10_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g10_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change11_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g11_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change12_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g12_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change13_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g13_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change14_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g14_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change15_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g15_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change16_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g16_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change17_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g17_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change18_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g18_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change19_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g19_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change20_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g20_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change21_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g21_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change22_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g22_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change23_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g23_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change24_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g24_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change25_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g25_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change26_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g26_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change27_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g27_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change28_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g28_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change29_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g29_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change30_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g30_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change31_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g31_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change32_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g32_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change33_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g33_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change34_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g34_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change35_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g35_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change36_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g36_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change37_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g37_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change38_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g38_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change39_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g39_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change40_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g40_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change41_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g41_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change42_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g42_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change43_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g43_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change44_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g44_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change45_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g45_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change46_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g46_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change47_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g47_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change48_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g48_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change49_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g49_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change50_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g50_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change51_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g51_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change52_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g52_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change53_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g53_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change54_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g54_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change55_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g55_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change56_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g56_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change57_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g57_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change58_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g58_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change59_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g59_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change60_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g60_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change61_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g61_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change62_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g62_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change63_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g63_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change64_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g64_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change65_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g65_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change66_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g66_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change67_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g67_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change68_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g68_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change69_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g69_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change70_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g70_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change71_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g71_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change72_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g72_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change73_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g73_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change74_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g74_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change75_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g75_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change76_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g76_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change77_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g77_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change78_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g78_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change79_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g79_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change80_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g80_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change81_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g81_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change82_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g82_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change83_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g83_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change84_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g84_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change85_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g85_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change86_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g86_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change87_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g87_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change88_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g88_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change89_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g89_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change90_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g90_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        void change91_Copy2()
        {
            byte a, b, c, d;

            a = byte.Parse(r.Next(255).ToString());
            b = byte.Parse(r.Next(255).ToString());
            c = byte.Parse(r.Next(255).ToString());
            d = byte.Parse(r.Next(255).ToString());
            g91_Copy2.Background = new SolidColorBrush(Color.FromArgb(a, b, c, d));

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            speed = 1000;
            myTimer.Interval = speed; // 1000 ms is one second
            this.Title = " Disco | Speed is " + (Double.Parse(speed.ToString()) / 1000).ToString() + " Sec";
            myTimer.Start();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            myTimer.Stop();
            Application.Current.Shutdown();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            myTimer.Stop();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Window_Loaded(sender, e);
        }

        private void inc_Click(object sender, RoutedEventArgs e)
        {            
            if(speed-100>=100)
            {
                myTimer.Stop();
                speed -= 100;
                myTimer.Interval = speed;
                myTimer.Start();
                this.Title = " Disco | Speed is " + (Double.Parse(speed.ToString()) / 1000).ToString() + " Sec";
            }
            else if(speed-10>0)
            {
                myTimer.Stop();
                speed -= 10;
                myTimer.Interval = speed;
                myTimer.Start();
                this.Title = " Disco | Speed is " + (Double.Parse(speed.ToString()) / 1000).ToString() + " Sec";
            }
        }

        private void dec_Click(object sender, RoutedEventArgs e)
        {
            myTimer.Stop();
            speed += 100;
            myTimer.Interval = speed;
            myTimer.Start();
            this.Title = " Disco | Speed is " + (Double.Parse(speed.ToString())/1000).ToString() + " Sec";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                inc_Click(sender, e);
                e.Handled = true;
            }
            else if(e.Key==Key.Down)
            {
                dec_Click(sender, e);
                e.Handled = true;
            }
            else if(e.Key==Key.Left)
            {
                start_Click(sender, e);
                e.Handled = true;
            }
            else if(e.Key==Key.Right)
            {
                stop_Click(sender, e);
                e.Handled = true;
            }
            else if(e.Key==Key.Escape)
            {
                exit_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
