using Enum_Downcasting_Practic.Models;
using System;

namespace Enum_Downcasting_Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //GetElements(1, 2, 3, 4, 5);
            #endregion

            #region Enum
            //CheckRole(0);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null;
            //int? age = null;

            //var result = age == null ? 55 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.Word.Tostring());
            #endregion

            #region Struct
            //Test1 test = new Test1("Emil");
            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2();
            #endregion

            #region UpcastingBoxingImplicit
            //Porscheturbo porscheturbo1 = new Porscheturbo();
            //Porscheturbo Porscheturbo3 = new Porscheturbo();
            //Bmw750 bmw7501 = new Bmw750();
            //Cars bmw7502 = new Bmw750();

            //Cars Porscheturbo2 = porscheturbo1;

            //Cars[] CarsModels = { porscheturbo1, Porscheturbo2, Porscheturbo3, bmw7501, bmw7502 };

            //foreach (var item in CarsModels)
            //{
            //    item.Speed();
            //}
            //#endregion

            //#region DowncastingUnboxingExplicit
            //Bmw750 bmw_7501 = new Bmw750();
            //Cars bmw_7502 = new Bmw750();

            //Bmw750 bmw7503 = (Bmw750)bmw7502;

            //object[] objects = { 2, 5, "P130", bmw7502 };

            //foreach (var item in objects)
            //{
            //    Bmw750 bmw750 = item as Bmw750;

            //    if (bmw750 != null)
            //    {
            //        Console.WriteLine(bmw750.HorsePower);
            //    }
            //    if (item is Bmw750)
            //    {
            //        ((Bmw750)item).HorsePower = 420;

            //        Console.WriteLine(((Bmw750)item).HorsePower);
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
        //        case (int)Roles.Dekan:
        //            Console.WriteLine("Dekan");
        //            break;

        //        case (int)Roles.Zamdekan:
        //            Console.WriteLine("Zamdekan");
        //            break;

        //        case (int)Roles.Ishci:
        //            Console.WriteLine("Ishci");
        //            break;

        //        default:
        //            Console.WriteLine("Role Id tapilmadi");
        //            break;
        //    }
        //}
        #endregion
    }
    #region Enum
    //enum Roles
    //{
    //    Dekan,
    //    Zamdekan,
    //    Ishci
    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int? Number { get; set; }
    //    public string Word { get; set; }
    //}
    #endregion

    #region Struct
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
    #endregion
}
