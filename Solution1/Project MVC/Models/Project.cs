namespace Project_MVC.Models
{
	public class Project
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Client { get; set; }
		public string Image { get; set; }


		public Project(long id, string name, string description, string client, string image)
		{
			ID = id;
			Name = name;
			Description = description;
			Client = client;
			Image = image;
		}
	}	
}
