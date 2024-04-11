using Flunt.Notifications;

namespace GameForce.Domain.Core.Commands
{
    public abstract class Command : Notifiable<Notification>
    {
        public abstract bool IsValid();
    }
}
