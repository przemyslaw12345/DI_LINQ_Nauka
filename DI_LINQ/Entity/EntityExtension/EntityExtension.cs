using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DI_LINQ.Entity.EntityExtension
{
	public static class EntityExtension
	{
		public static T? Copy<T>(this T itemCopy)
		where T : IEntity
		{
			var json = JsonSerializer.Serialize<T>(itemCopy); //serializes the input data to json file
			return JsonSerializer.Deserialize<T>(json); // deserialized the json data and returns the value
		}
	}
}
