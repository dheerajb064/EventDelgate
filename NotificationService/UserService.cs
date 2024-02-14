namespace NotificationService
{
    internal class UserService
    {
        private UserRepository _repository = new UserRepository();


        public event EventHandler<UserEventArgs> UserChanged;

        public void AddUser(string name ,string email ,string contact)
        {
            _repository.AddUser(name, email, contact);
            UserChanged.Invoke(null , new UserEventArgs(name, email, UserActionType.Added));
        }

        public void UpdateUser(string[] properties ,int userId)
        {
            _repository.UpdateUser(userId ,properties);
            UserChanged.Invoke(null, new UserEventArgs(properties[0], properties[1], UserActionType.Updated));
        }

        public void DeleteUser(int userId)
        {
            User user = _repository.GetUser(userId);
            _repository.DeleteUser(userId);
            UserChanged.Invoke(null, new UserEventArgs(user.Name, user.Email, UserActionType.Removed));
        }

        public void DisplayUsers()
        {
            _repository.ShowUsers();
        }


    }
}
