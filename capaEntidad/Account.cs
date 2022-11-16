namespace capaEntidad
{
    [Serializable]
    public class Account
    {
        private int id;
        private String name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Account()
        {
        }

    }
}