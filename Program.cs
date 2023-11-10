using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Tapşırıq:
            //İsArrayContains methodu var parametr olaraq iki int arrayi alır və ikinci arrayın birinci arrayin daxilində olub olmadığın qaytarır.
            //Məsələn: arr1 = [2, 3, 4, 7]
            //arr2 = [3, 2, 7]-> false

            //arr1 = [2, 3, 4, 7]
            //arr2 = [3, 4]-> true

            //(not nümunələrdən aydın olduğu kimi burda ikinci array sıralaması ilə və bütün ədədləri ilə birlikdə 1ci arrayda olmalıdır,
            //bütün rəqəmləri 1 ci arraydə olsa belə sıralamasına da baxmaq lazımdır)


            //Tapşırıq: simple schoolmanagement appi:

            //User və Student classınız var.Student classında Name Surname Username Password propertyləri var. Student classında isə
            //yuxarıdakı propertylərdən əlavə Grade propertysi də var.
            //Özünüzdə User arrayi saxlayıb içində bir neçə data saxlayın.App run olanda istifadəçidən username və passvord istəyin.
            //Əgər daxil edilən username və passvorddə olan user vardırsa və bu user studentdirsə,
            //Grade - i ekrana çap olunsun.

            //Qeyd!!! hazır metodlardan istifadə etməyin

            Console.WriteLine(IsArrayContains(int[] { 3, 6, 9}, arr2 [ 3,6,8]));
        }
        static bool IsArrayContains(int[] arr, int[] arr2)
        {
            foreach (int i in arr2)
            {
                if (arr[i] == arr2[i])
                    return true;
            }return false;
        }
    }
}


