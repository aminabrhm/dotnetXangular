// using ContosoFeature.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace ContosoFeature.Services
// {
//     public static class FeatureService
//     {
//         static List<Feature> Features { get; }
//         static int nextId = 3;
//         static FeatureService()
//         {
//             Features = new List<Feature>
//             {
//                 new Feature { Id = 1, Name = "Feature1" },
//             };
//         }

//         public static List<Feature> GetAll() => Features;

//         public static Feature Get(int id) => Features.FirstOrDefault(p => p.Id == id);

//         public static void Add(Feature feature)
//         {
//             feature.Id = nextId++;
//             Features.Add(feature);
//         }

//         public static void Delete(int id)
//         {
//             var feature = Get(id);
//             if(feature is null)
//                 return;

//             Features.Remove(feature);
//         }

//         public static void Update(Feature feature)
//         {
//             var index = Features.FindIndex(p => p.Id == feature.Id);
//             if(index == -1)
//                 return;

//             Features[index] = feature;
//         }
//     }
// }