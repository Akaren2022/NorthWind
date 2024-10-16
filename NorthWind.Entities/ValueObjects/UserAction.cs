namespace NorthWind.Entities.ValueObjects
{
	public class UserAction(String user, string descripcion)
	{
		public DateTime CreatedDateTime { get; } = DateTime.Now;
		public string User => user;
		public string Descripcion => descripcion;
    }
}
