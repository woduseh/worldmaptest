using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Character Character;

    public void LeftClick()
    {
        if (Character.GetComponent<Animator>().GetBool("IsMoving")) return;
            Character.TrySetDirection(Direction.Left);
    }

    public void RightClick()
    {
        if (Character.GetComponent<Animator>().GetBool("IsMoving")) return;
            Character.TrySetDirection(Direction.Right);
    }

    public void UpClick()
    {
        if (Character.GetComponent<Animator>().GetBool("IsMoving")) return;
            Character.TrySetDirection(Direction.Up);
    }

    public void DownClick()
    {
        if (Character.GetComponent<Animator>().GetBool("IsMoving")) return;
            Character.TrySetDirection(Direction.Down);
    }
}