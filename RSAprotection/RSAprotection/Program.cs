using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RSAprotection
{
    class Program
    {
        static void Main(string[] args)
        {
             int angoucode = 250;
            long realcode = 0;
            long angoukey = 47;
            //double fukugoukeysub = 0;
            long M = 323;  //17*19
            long fukugoukey = 95;
            //long angoucodesub = 0;
            long separatenum = 6;
            long[] separatemode = new long[separatenum];
            byte[] bytesutf8;
            List<int> cryptgragh = new List<int>();
            long a;
            List<byte[]> nuu = new List<byte[]>() ;
            int loopcount;
            
            //StreamReader sr = new StreamReader(Properties.Resources.heibun, Encoding.UTF8);
          
            //string angou = sr.ReadToEnd();

            //sr.Close();


            string nu = Properties.Resources.plaintext;

        byte[]  abytesutf8 = UTF8Encoding.UTF8.GetBytes(nu);




            //string[] num =  nu.Split('/');
            


            
 //           for (int i = 0; i < num.Length; i++)
 //           {
 //            nuu.Add(UTF8Encoding.UTF8.GetBytes(num[i]));
           
 //}

 //                   foreach (byte[] n in nuu){
 //                       for (int i = 0; i < n.Length; i++) { 
 //                           angoucode = (int)n[i];
 //                           bytes.Add((int)angoucode);
 //                   }

  foreach ( byte n in abytesutf8) {
                    angoucode = n;
                    loopcount = mod(angoucode, M, separatemode, 0,angoukey);
             
                    separatenum = 1;

           for (int i = 0; i < loopcount; i++)
            {
                    separatenum *= separatemode[i];
            }    

   separatenum %= M;
   cryptgragh.Add((int)separatenum);
            }

          // StreamWriter sw = new StreamWriter(@"C:", true, Encoding.UTF8);
           
           //Console.SetOut(sw);

  foreach (int n in cryptgragh)
  {
      Console.Write("%{0}",n);
  }
      Console.Write("%");
           //sw.Dispose();  


                Console.Read();

        }
    
           static int mod(long num, long M, long[] sep, int i,long key) //繰り返し二乗法
            {

                if (key % 2 == 1)
                {
                    sep[i] = num;
                    i++;
                    if (key == 1) { return i; }

                }



                long k = num * num % M;

                return mod(k, M, sep, i, key / 2);
            }



        
           //    long angoucode = 250;
           //    long realcode = 0;
           //    long angoukey = 47;
           //    //double fukugoukeysub = 0;
           //    long M = 323;
           //    long fukugoukey = 95;
           //    //long angoucodesub = 0;
           //    long separatenum = 6;
           //    long[] separatemode = new long[separatenum];
           //    byte[] bytesutf8;
           //    List<byte> bytes = new List<byte>();
           //    long a;

           //    //while (angoucode != angoucodesub)   //暗号キーから複合キーを求める。
           //    //while ((144 * i + 1) % 47!=0)
           //    //{


           //    //    //realcode = (long)(Math.Pow(angoucode, fukugoukeysub)) % M;  
           //    //    //angoucodesub = (long)(Math.Pow(realcode, angoukey)) % M;
           //    //    i++;
           //    //    fukugoukeysub = (144 * i + 1) / 47;
           //    //    fukugoukey = fukugoukeysub;

           //    //}
           //    //Console.WriteLine(fukugoukey);
           //    //Console.WriteLine(i);





        
        }
    }

