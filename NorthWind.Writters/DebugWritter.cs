namespace NorthWind.Writters
{
	internal class DebugWritter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			Debug.WriteLine("Console Writter: {0}, {1}, {2}", action.CreatedDateTime, action.User, action.Descripcion);
		}
	}
}
