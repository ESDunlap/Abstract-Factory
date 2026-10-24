using UnityEngine;

public class Beggar : MonoBehaviour, INPC
{
    [SerializeField] private GameObject holdingCupPrefab;
    [SerializeField] private float shakingPauseTime = 0.5f;
    private GameObject holdingCup;
    private bool moveCupUp;
    private bool shakingPause = false;
    private float shakingPauseTimer = 0;
    public void Spawn()
    {
        holdingCup = Instantiate(holdingCupPrefab);
        holdingCup.transform.parent = transform;
        holdingCup.transform.localPosition = new Vector3(0.6f,0.1f,-0.4f);
    }

    public void Speak()
    {
        Debug.Log("Do you have some spare change?");
    }

    public void Move()
    {
        if (shakingPause)
        {
            shakingPauseTimer += Time.deltaTime;
            if (shakingPauseTimer > shakingPauseTime)
            {
                shakingPause = false;
                shakingPauseTimer = 0;
            }
        }
        else if (moveCupUp)
        {
            holdingCup.transform.position += new Vector3(0f, 1f) * Time.deltaTime;
            if (holdingCup.transform.localPosition.y > 0.2f)
            {
                moveCupUp = !moveCupUp;
            }
        }
        else
        {
            holdingCup.transform.position += new Vector3(0f, -1f) * Time.deltaTime;
            if (holdingCup.transform.localPosition.y < 0f)
            {
                moveCupUp = !moveCupUp;
                shakingPause = true;
            }
        }

    }
}