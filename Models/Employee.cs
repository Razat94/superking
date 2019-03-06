using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreWithMongoApplication.Model
{
 public class Product
 {
 [BsonId]
 public string Id { get; set; }
 [Display(Name = "Product Name")]
 public string Name { get; set; }
 [Display(Name = "Product Code")]
 public string Code { get; set; }
 [Display(Name = "Product Category")]
 public string ProductCategory { get; set; }
 }
}