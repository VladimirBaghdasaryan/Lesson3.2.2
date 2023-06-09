using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Lesson3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Տրված են ո բնական թիվը և ո տարր պարունակող X միաչափ զանգվածը: 
            //Կազմել այնպիսի նոր Y վեկտորի ստացման և տպման բլոկ - սխեման ու ծրագիրը, որի տարրերը ստացվում են

            //int[] array = { 2, -13, 44, 15, 8, 17, -25 };

            //281.տրված զանգվածի դրական տարրերից:

            //int[] DrakanMassiv(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i]>0)
            //        {
            //            count++;
            //        }
            //    }

            //    int [] drakan = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > 0)
            //        {
            //            drakan[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return drakan;
            //}

            //int[] Y = DrakanMassiv(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}

            //282.տրված զանգվածի դրական և բացասական տարրերից:

            //int[] BacasakanMassiv(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] bacasakan = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < 0)
            //        {
            //            bacasakan[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return bacasakan;



            //}

            //int[] Y = BacasakanMassiv(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine( Y.GetLength);


            //տրված զանգվածի կենտ արժեք ունեցող տարրերից:

            //int[] KentMassiv(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i]%2!= 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] kent = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 2 != 0)
            //        {
            //            kent[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return kent;



            //}

            //int[] Y = KentMassiv(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item); 
            //}


            //284.տրված զանգվածի[a;b] միջակայքին պատկանող տարրերից:

            //int[] mijakayq(int[] arr,int a,int b)
            //{
            //    int count = 0;
            //    for (int i = a; i <= b; i++)
            //    {
            //        if ((a > 0 && a <= arr.Length) && b <= arr.Length)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] kent = new int[count];
            //    int index = 0;
            //    for (int i = a; i <= b; i++)
            //    {
            //        if ((a > 0 && a <= arr.Length) && b <= arr.Length)
            //        {
            //            kent[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return kent;

            //}


            //int[] Y = mijakayq(array,1,5);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}

            //285.տրված զանգվածի այն տարրերից, որոնք բազմապատիկ են տրված ք թվին:


            //int[] Bazmapatik(int[] arr, int a)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % a == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] bazmapatik = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % a == 0)
            //        {
            //            bazmapatik[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return bazmapatik;
            //}

            //int[] Y = Bazmapatik(array, 2);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}


            //286.տրված զանգվածի զույգ արժեք ունեցող տարրերից:

            //int[] ZuygMassiv(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 2 == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] zuyg = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 2 == 0)
            //        {
            //            zuyg[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return zuyg;



            //}

            //int[] Y = ZuygMassiv(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}


            //287.տրված զանգվածի այն տարրերից, որոնց ինդեքսը հավասար չէ այդ տարրի արժեքին:

            //int[] IndexTarr(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i]!=i)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] ind = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] !=i)
            //        {
            //            ind[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return ind;



            //}

            //int[] Y = IndexTarr(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}


            //288.տրված զանգվածի կենտ ինդեքս ունեցող տարրերից:

            //int[] KentIndex(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i%2!=0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] kentindex= new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            kentindex[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return kentindex;



            //}

            //int[] Y = KentIndex(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}


            //289.տրված զանգվածի այն տարրերից, որոնց քառակուսիները պատկանում են տրված(c; d) միջակայքին

            //int[] Arr(int[] arr, int c, int d)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Pow(arr[i], 2) >= c && Math.Pow(arr[i], 2) <= d)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] fo = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Pow(arr[i], 2) >= c && Math.Pow(arr[i], 2) <= d)
            //        {
            //            fo[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return fo;



            //}

            //int[] Y = Arr(array,1,4);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}



            //290.տրված զանգվածի այն տարրերից, որոն 6 - ի բամանելիս կմնա 1 մնացորդ


            //int[] foo(int[] arr)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 6 == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] f1 = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 6 == 0)
            //        {
            //            f1[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return f1;



            //}

            //int[] Y = foo(array);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}

            //297.այն տարրերը, որոնց բացարձակ արժեքները մեծ են տրված k թվից:


            //int[] foo1(int[] arr, int k)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Abs(arr[i]) > k)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] ff = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Abs(arr[i]) > k)
            //        {
            //            ff[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return ff;



            //}

            //int[] Y = foo1(array,2);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}

            //300.այն տարրերը, որոնց քառակուսիները փոքր են տրված թվից:


            //int[] foo2(int[] arr, int k)
            //{
            //    int count = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Pow(arr[i], 2) < k)
            //        {
            //            count++;
            //        }
            //    }

            //    int[] f = new int[count];
            //    int index = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (Math.Pow(arr[i], 2) < k )
            //        {
            //            f[index] = arr[i];
            //            index++;
            //        }
            //    }

            //    return f;



            //}

            //int[] Y = foo2(array, 222);

            //foreach (var item in Y)
            //{
            //    Console.WriteLine(item);
            //}


            //Տրված են ո բնական թիվը և ո տարը պարունակող X միաչափ զանգվածը: 
            //Կազմել տրված խնդիրների լուծման բլոկ - սխեմաները ու ծրագրերը, որոնք կհաշվեն և կտպեն

            //int[] array2 = { 93, 4, 2, 4, 484,-9};

            //333.զանգվածի այն(բացառությամբ առաջին և վերջին) տարրերի գումարը, 
            //    որոնց նախորդ և հաջորդ տարրերի գումարը փոքր է տրված k թվից:


            //void foo(int[] array, int k)
            //{
            //    int sum = 0;
            //    for (int i = 1; i < array.Length - 1; i++)
            //    {
            //        if ((array[i - 1] + array[i + 1]) < k)
            //        {
            //            sum += array[i];
            //        }
            //    }
            //    Console.WriteLine(sum);
            //}

            //foo(array2, 9);


            //334.զանգվածի դրական տարրերի գումարը, եթե վեկտորի առաջին մեծագույն տարրի համարը 
            //    մեծ չէ k / 2 - ից, հակառակ դեպքում բացասական տարրերի արտադրյալը:


            //void foo1(int[] array, int k)
            //{
            //    int max = array[0];
            //    int index = 0;
            //    int sum = 0;
            //    int summinus = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > array[0])
            //        {
            //            max = array[i];
            //            index=i;
            //            break;
            //        }
            //    }
            //    if (index<k/2)
            //    {
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i]>0)
            //            {
            //                sum += array[i];
            //            }
            //        }
            //        Console.WriteLine(sum);
            //    }
            //    else
            //    {
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i]<0)
            //            {
            //                summinus += array[i];
            //            }
            //        }
            //        Console.WriteLine(summinus);
            //    }


            //}

            //foo1(array2,22);


            //335.զանգվածի այն(բացառությամբ առաջին և վերջին) տարրի համարը և արժեքը, 
            //    որի նախորդ և հաջորդ տարրերի արժեքների գումարը ամենամեծն է նման եղանակով
            //    ստացվող բոլոր հնարավորներից: Ենթադրվում է, որ զանգվածում կա միայն մեկ այդպիսի տարը:


            //void foo2(int[] array)
            //{
            //    int maxsum = array[0] + array[2];
            //    int index = 0;
            //    int value = 0;

            //    for (int i = 2; i < array.Length - 1; i++)
            //    {
            //        if ((array[i - 1] + array[i + 1]) > maxsum)
            //        {
            //            maxsum = array[i - 1] + array[i + 1];
            //            index = i;
            //            value = array[i];
            //            Console.WriteLine($"index: {index} Value: {value}");
            //        }

            //    }
            //    if (index == 0)
            //    {
            //        Console.WriteLine($"index: 1 Value: {array[1]}");
            //    }
            //}

            //foo2(array2);

            //336.զանգվածի մեծագույն տարրը, եթե զանգվածը պարունակում է
            //    գոնե մեկ բացասական տարր, հակառակ դեպքում տպել s = 0:


            //void foo3 (int [] array) 
            //{
            //    int max = array[0];
            //    bool minus = false;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > max)
            //        {
            //            max = array[i];
            //        }
            //        if (array[i]<0)
            //        {
            //            minus = true;

            //        }
            //    }
            //    if (minus)
            //    {
            //        Console.WriteLine(max);
            //    }
            //    else
            //    {
            //        Console.WriteLine("s=0");
            //    }
            //}

            //foo3(array2);


            //337.զանգվածի կենտ ինդեքսով տարրերի գումարը, եթե զույգ ինդեքսով տարրերի արտադրյալը դրական է,
            //    հակառակ դեպքում տպել s = 1:

            //void foo4(int[] array) 
            //{
            //    int kentsum = 0;
            //    int zuygsum = 1;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (i%2==0)
            //        {
            //            kentsum += array[i];
            //        }
            //        else if(i%2!=0) 
            //        {
            //            zuygsum*= array[i];
            //        }
            //    }

            //    if (zuygsum>0)
            //    {
            //        Console.WriteLine(kentsum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("s=1");
            //    }
            //}

            //foo4(array2);

            //338.զանգվածի բոլոր մեծագույն(ոչ միակը) տարրերի ինդեքսների գումարը:

            //void foo5(int[] array)
            //{
            //    int max = array[0];
            //    int sum = 0;
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i]>max)
            //        {
            //            max += array[i];
            //            sum+=i;
            //        }
            //        else if (array[i] == max)
            //        {
            //            sum += i;
            //        }
            //    }
            //    Console.WriteLine(sum);
            //}

            //foo5(array2);

            //340.զանգվածի այն տարրերի փոքրագույն արժեքը, որոնց ինդեքսների արժեքները 5 - ի բաժանելիս կմնա 2 մնացորդ:

            //void foo6(int[] array)
            //{
            //    int min = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 5 == 2)
            //        {
            //            min = array[i];
            //            break;
            //        }
            //    }
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 5 == 2)
            //        {
            //            if (min > array[i])
            //            {
            //                min = array[i];
            //            }
            //        }
            //    }
            //    Console.WriteLine(min);
            //}

            //foo6(array2);

        }
    }
}