using System.Net;

namespace OPP04G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01


            //a)  فاصيل المعقدة للكود، وإظهار الميزات الأساسية فقط للمستخدم. (التركيز على ماذا يفعل الكائن وليس كيف يفعل ذلك
            //b)تقليل التعقيد: يجعل الكود أسهل في الفهم والاستخدام.

            //سهولة الصيانة: يمكنك تعديل الكود الداخلي دون أن يخرب باقي البرنامج.
            #endregion

            #region 02
            //            a)Abstract Class:

            //يورث لكلاس واحد فقط(Single Inheritance).

            //يحتوي على متغيرات(Variables) ودوال بها كود جاهز أو دوال مجردة.

            //يعبر عن علاقة "نوع من"(Is - A).

            //Interface:

            //يمكن تطبيقه مع أكثر من Interface بنفس الوقت.

            //يحتوي على عقود وتعاريف للدوال فقط(بدون متغيرات أو كود).

            //يعبر عن علاقة "قدرة أو سلوك"(Can - Do).

            //            b)عندما نريد إضافة سلوك مشترك لكلاسات غير مرتبطة ببعضها.

            //عندما نحتاج لتطبيق أكثر من سلوك(Multiple Inheritance) في نفس الكلاس.

            //            c)Multiple Abstract Classes: No(لا، C# تدعم الوراثة من كلاس واحد فقط).

            //Multiple Interfaces: Yes(نعم، يمكن تطبيق عدة واجهات في نفس الوقت).
            #endregion

            #region 03

            //StandardShipment standard = new StandardShipment("SH001", "Laptop", 5m, 70m);
            //ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 4m, 80m);
            //International international = new International("SH003", "Documents", 12m, 200m);

            //DeliveryCenter center = new DeliveryCenter();
            //center.AddShipment(standard);
            //center.AddShipment(express);
            //center.AddShipment(international);

            //Console.WriteLine("Delivery Center");
            //Console.WriteLine();
            //center.PrintAllShipments();

            //Console.WriteLine("Tracking Status");
            //Console.WriteLine();
            //center.PrintTrackingstatus();

            //Console.WriteLine();
            //Console.WriteLine("Insurance");
            //Console.WriteLine();

            //ITrackable[] trackableShipments = new ITrackable[] { standard, express, international };

            //IInsurable[] insurableShipments = new IInsurable[] { standard, express, international };

            //DeliveryReport.PrintInsurance(standard);
            //DeliveryReport.PrintInsurance(express);
            //DeliveryReport.PrintInsurance(international);

            //Console.WriteLine();
            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion
        }
    }
}
