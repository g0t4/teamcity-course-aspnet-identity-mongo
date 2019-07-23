namespace Tests
{
	using MongoDB.Bson;

	public static class ObjectIdHelpers
	{
		public static ObjectId? SafeParseObjectId(this string id)
		{
			int i = 155;
			ObjectId parsed;
			if (ObjectId.TryParse(id, out parsed))
			{
				return parsed;
			}
			return null;
		}
	}
}