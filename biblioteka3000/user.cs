namespace biblioteka3000
{
    public class User
    {
        private string _login;

        public string Login
        {
            get => _login;
            set => _login = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        private string _password;

        public string Password
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        private List<Multimedia> _multimedias;

        public List<Multimedia> Multimedias
        {
            get => _multimedias;
            set => _multimedias = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}