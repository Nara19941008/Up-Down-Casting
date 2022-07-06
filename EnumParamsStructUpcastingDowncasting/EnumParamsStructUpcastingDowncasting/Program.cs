using System;

namespace EnumParamsStructUpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //int[] arr = { 1, 2, 3, 4 };
            //GetElements(1, 2, 3, 4, 5, 8, 7, 9);
            #endregion
            #region Enum
            //CheckRole(0);
            //CheckWeekDay(5);
            #endregion

            #region Nullable

            //Test test = new Test();
            //Console.WriteLine();

            //string name = null;
            //int? age = null;
            //Console.WriteLine(age);

            //var result = age == null ? 55 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;

            //Console.WriteLine(test.Word.ToString());
            #endregion

            #region Struck
            //Test1 test = new Test1("Orxan");

            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2();
            #endregion

            #region Upcasting
            //byte m = 5;
            //int n = m;

            //Eagle eagle1 = new Eagle();
            //Eagle eagle3 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Animal eagle2 = eagle1;

            //Animal[] animals = { eagle1, eagle2, eagle3, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}
            #endregion

            #region Downcasting
            //int m = 15;
            //byte n = (byte)m;
            //Console.WriteLine(n);

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //object[] objects = { 2, 5, "P130", shark2 };

            //foreach (var item in objects)
            //{
            //    Shark shark = item as Shark;

            //    if (shark != null)
            //    {
            //        Console.WriteLine(shark.Weight);
            //    }
            //    if (item is Shark)
            //    {
            //        ((Shark)item).Weight = 500;

            //        Console.WriteLine(((Shark)item).Weight);
            //    }
            //}
            #endregion

        }



        #region Params
        //public static void GetElements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("Super admin");
        //            break;
        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;
        //        case (int)Roles.Member:
        //            Console.WriteLine("Member");
        //            break;
        //        default:
        //            Console.WriteLine("Not found role id");
        //            break;
        //    }
        //}
        //static void CheckWeekDay(int weekId)
        //{
        //    switch (weekId)
        //    {
        //        case (int)Week.Sunday:
        //            Console.WriteLine("Bazar gunu");
        //            break;
        //        case (int)Week.Monday:
        //            Console.WriteLine("Bazar ertesi gunu");
        //            break;
        //        case (int)Week.Tuesday:
        //            Console.WriteLine("Chershenbe axshami gunu");
        //            break;
        //        case (int)Week.Wednesday:
        //            Console.WriteLine("Chershenbe gunu");
        //            break;
        //        case (int)Week.Thursday:
        //            Console.WriteLine("Cume axshami gunu");
        //            break;
        //        case (int)Week.Friday:
        //            Console.WriteLine("Cume gunu");
        //            break;
        //        case (int)Week.Saturday:
        //            Console.WriteLine("Shenbe gunu");
        //            break;
        //        default:
        //            Console.WriteLine("Not found");
        //            break;
        //    }
        //    }
        //}
        //public enum Roles
        //{
        //    SuperAdmin,
        //    Admin,
        //    Member
        //}

        //public enum Week
        //{
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}
        #endregion

    }

    #region Struck
    //struct Test1 
    //{
    //    public int Num { get; set; }
    //    public Test1(string name)
    //    {
    //        Num = 66;
    //        Console.WriteLine(Num);
    //    }
    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 66;

    //    public Test2()
    //    {
    //        Console.WriteLine("Bosh");
    //    }

    //    public Test2(int b)
    //    {
    //        Console.WriteLine("Dolu");
    //    }
    //}

    //struct Test3
    //{

    //}

    //interface ITest
    //{

    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int? Number { get; set; }

    //    public string Word { get; set; }
    //}
    #endregion




}
