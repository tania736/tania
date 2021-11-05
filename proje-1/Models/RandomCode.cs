using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje_1.Models
{
    public class RandomCode
    {
         public static string GenerateActivateCode()
             {
                 return Guid.NewGuid().ToString().Replace("-", "");
              }

             public static string GenerateCode()
             {
                  return Guid.NewGuid().ToString().Replace("-", "");
            }


        }
    }