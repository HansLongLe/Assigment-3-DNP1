using System;

namespace Client.Data
{
    public class Validator : IValidator
    {
        public bool Authorized { get; set; }
        public event Action OnChange;

        public void Set(bool authorize)
        {
            Authorized = authorize;
            NotifyStateChanged();
        }

        public bool GetAuthorization()
        {
            return Authorized;}

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}