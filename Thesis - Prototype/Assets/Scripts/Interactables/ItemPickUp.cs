using UnityEngine;

public class ItemPickUp : Interactable {

	public ItemPickUp instance;
	public Item item;	// Item to put in the inventory if picked up

	// When the player interacts with the item
	
	void Awake ()
	{
		if (instance != null)
		{
			Destroy(this.gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
	}

	void Start () 
	{
		
	}
	public override void Interact()
	{
		base.Interact();
		
		PickUp();
	}

	// Pick up the item
	public void PickUp ()
	{
		Debug.Log("Picked up " + item.name);
		Inventory.instance.Add(item);	// Add to inventory

		Destroy(gameObject);	// Destroy item from scene
	}

}