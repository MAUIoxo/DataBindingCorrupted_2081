using CommunityToolkit.Mvvm.Messaging.Messages;

namespace DataBindingCorruptedExample.ViewModels.Messages
{
    public class UpdateSelectedStoreItemsMessage : ValueChangedMessage<bool>
    {
        public UpdateSelectedStoreItemsMessage(bool value) : base(value)
        {
            
        }
    }
}
