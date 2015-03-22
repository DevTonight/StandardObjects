using System;

namespace StandardObjects
{
	/// <summary>
	/// The Item class will is a generic class that can be used to describe
	/// physical objects, documents, or any other entity.  For example,
	/// an Item can be a Product or be a part of a Product.
	/// </summary>
	/// 03/22/2015 - Added ItemID, Name, and Description properties.
	public class Item
	{
		public Guid ItemID {get;set;}
		public string Name {get;set;}
		public string Description {get;set;}
	}
}

