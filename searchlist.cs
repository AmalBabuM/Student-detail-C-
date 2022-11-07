using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rough
{
    public class searchlist
    {
        public static void Main(string[] args)
        {   string search;
            List<Student> detail= new List<Student>();
            detail.Add(new Student());
            detail[0].age=20;
            detail[0].name="amal";
            detail[0].department="science";

            detail.Add(new Student());
            detail[1].age=23;
            detail[1].name="Rohit";
            detail[1].department="commerce";

            detail.Add(new Student());
            detail[2].age=22;
            detail[2].name="Rahul";
            detail[2].department="Science";

            System.Console.WriteLine("Enter the name of the student");
            search=Console.ReadLine();

            int flag=0;
            for(int i=0;i<detail.Count;i++)
            {
                if(detail[i].name==search)  
                {
                    System.Console.WriteLine("Details found");
                    System.Console.WriteLine(detail[i].getdata());
                    flag=1;
                    break;
                }
                // else
                // {
                //     System.Console.WriteLine("Deatails not found");
                    // break;
                    
                // }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Not found");
            }
            
        }
    }
}