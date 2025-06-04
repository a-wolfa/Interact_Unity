using Interactable;
using Visitors.Abstractions;

namespace Visitors
{
    public class PlayerInteractionVisitor : IInteractionVisitor
    {
        public void Visit(TreasureChest treasureChest)
        {
            treasureChest.Open();
        }

        public void Visit(Door door)
        {
            if (!door.IsLocked)
            {
                door.Open();
            }
            else
            {
                // Handle locked door interaction
                UnityEngine.Debug.Log("The door is locked!");
            }
        }
    }
}