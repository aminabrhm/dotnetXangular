// using ContosoVega.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace ContosoVega.Services
// {
//     public static class VegaService
//     {
//         static List<Vega> Vegas { get; }
//         static int nextId = 3;
//         static VegaService()
//         {
//             Vegas = new List<Vega>
//             {
//                 new Vega {Id = 1, Name = "Make1"} ,
//                 new Vega { Id = 2, Name = "Make2"}
//             };
//         }

//         public static List<Vega> GetAll() => Vegas;

//         public static Vega Get(int id) => Vegas.FirstOrDefault(p => p.Id == id);

//         public static void Add(Vega vega)
//         {
//             vega.Id = nextId++;
//             Vegas.Add(vega);
//         }

//         public static void Delete(int id)
//         {
//             var vega = Get(id);
//             if(vega is null)
//                 return;

//             Vegas.Remove(vega);
//         }

//         public static void Update(Vega vega)
//         {
//             var index = Vegas.FindIndex(p => p.Id == vega.Id);
//             if(index == -1)
//                 return;

//             Vegas[index] = vega;
//         }
//     }
// }