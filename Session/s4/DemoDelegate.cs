using System;

namespace T2008M_AP.Session.s4
{
    public delegate void ShowString(string msg);// khai bao 1 delegate co tra ve void va tham so la 1 string

    public class DemoDelegate
    {
        public event ShowString EventLog;
        public static ShowString publicDelegate = new ShowString(ShowMessage);
        public static void Main(string[] args)
        {
            // tao 1 instance delegate
            //  ShowString ss = new ShowString(ShowMessage); // ko phai truyen vao gia tri ma truyen vao ten ham co dang khai bao nhu delegate
            // ss("hahaha");
            //   ShowString ss2 = new ShowString(new DemoDelegate().ShowInfo);// voi ham non-static
            // ss2("Nguyen van An");
            // nếu cùng truyền vào 1 chuỗi
            // ss("mai văn nam");
            // ss2("mai văn nam");
            // ShowString ss3 = new ShowString(ShowMessage);
            //  publicDelegate += new DemoDelegate().ShowInfo;// napj thêm hàm vào danh sách quản lý của delegate
            // ss3("Mai văn nam");
            //  DemoDelegate2 dd2 = new DemoDelegate2();
            //  publicDelegate("Mai An Tiem");// chay delegate tuc la chay 1 leo 3 ham voi truyen cung 1 gia tri tham so
            DemoDelegate dd = new DemoDelegate();
            dd.ActiveEvent("su kien duoc kich hoat"); 
            // muc dich
            // de cho nhin thay co che su kien phat ra
        }

        public void ActiveEvent(string log)
        {
            if (EventLog == null)
            {
                EventLog += ShowMessage;
                EventLog += ShowInfo;
            }
            EventLog(log);
        }
        
        public static void ShowMessage(string s)
        {
            Console.WriteLine(s);
        }

        public void ShowInfo(string s)// chi co ô nhớ khi tao đối tượng
        {
            Console.WriteLine("hello :" +s);
        }
    }
}