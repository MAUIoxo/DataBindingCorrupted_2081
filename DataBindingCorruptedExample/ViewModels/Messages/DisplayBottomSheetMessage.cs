using CommunityToolkit.Mvvm.Messaging.Messages;

namespace DataBindingCorruptedExample.ViewModels.Messages
{
    public class DisplayBottomSheetMessage : ValueChangedMessage<bool>
    {
        public DisplayBottomSheetMessage(bool value) : base(value)
        {
            
        }
    }
}
