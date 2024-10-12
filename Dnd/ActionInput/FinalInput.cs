namespace Dnd.ActionInput;

public class FinalInput
{
    public ActionInput? ActionInput;
    public Player Player;

    public void StartInput()
    {
        ActionInput = new ActionInput();
        ActionInput.PlayerInput();
        Player = ActionInput.GetPlayer();
        ActionInput.RoomsInput();
    }

    public void OngoingInput()
    {
        
        while (Player.HP > 0)
        {
           
            if(ActionInput == null) ActionInput = new ActionInput();
            
            ActionInput.ActionsInput();
            
           
        }

        if (Player.HP <=0)
        {
            Console.WriteLine("You lose!");
        }
    }
}