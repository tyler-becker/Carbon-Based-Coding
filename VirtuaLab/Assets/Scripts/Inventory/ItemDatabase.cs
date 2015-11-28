using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;

public class ItemDatabase : MonoBehaviour
{
    private List<Item> database = new List<Item>();
    private JsonData itemData;
    string url;
    public WWW request;
	
	void Start()
    {
        Debug.Log(LoadUrl.url);
        Debug.Log(LoadUrl.request.text);

        itemData = JsonMapper.ToObject(LoadUrl.request.text);
        ConstructItemDatabase();
        Debug.Log(FetchItemByID(0).Description);
    }

    public Item FetchItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++)
        {
            if (database[i].ID == id)
                return database[i];
        }
        return null;
    }

    void ConstructItemDatabase()
    {
        for(int i = 0; i < itemData.Count; i++)
        {
            database.Add(new Item((int)itemData[i]["id"], itemData[i]["title"].ToString(), itemData[i]["concentration"].ToString(), (int)itemData[i]["stats"]["power"],
                (int)itemData[i]["stats"]["defense"], (int)itemData[i]["stats"]["vitality"], itemData[i]["description"].ToString(), (bool)itemData[i]["stackable"],
                (int)itemData[i]["rarity"], itemData[i]["slug"].ToString()));
        }
    }
}

public class Item
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Concentration { get; set;  }
    public int Power { get; set; }
    public int Defense { get; set; }
    public int Vitality { get; set; }
    public string Description { get; set; }
    public bool Stackable { get; set; }
    public int Rarity { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }
    public GameObject Object { get; set; }

    public Item(int id, string title, string concentration, int power, int defense, int vitality, string description, bool stackable,  int rarity, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Concentration = concentration;
        this.Power = power;
        this.Defense = defense;
        this.Vitality = vitality;
        this.Description = description;
        this.Stackable = stackable;
        this.Rarity = rarity;
        this.Slug = slug;
        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
        this.Object = Resources.Load<GameObject>("Objects/" + slug);

    }

    public Item()
    {
        this.ID = -1;
    }

    /*List<Item> jsonItems = new List<Item>();
    {

        new Item()
        {
            ID = 0,
            Title = "Sodium Hydroxide",
            
            Description = "0.1M NaOH",
            Stackable = false,
            Slug =  "NaOH"
        },
        new Item()
        {
            ID = 1,
            Title = "Hydrochloric Acid",
           
            Description = "\"x\"M HCl",
            Stackable = false,
            Slug = "HCl"
        },
        new Item()
        {
            ID = 2,
            Title = "Beaker",
            
            Description = "A 50mL beaker.",
            Stackable = false,
            Slug = "Beaker"
        },
        new Item()
        {
            id = 3,
            title = "Burette",
            
            description = "A 50mL burette.",
            stackable = false,
            slug =  "Burette"
        }
    };

    List<Item> resultObjectList = Newtonsoft.Json.JsonConvert.SerializeObject(jsonItems);*/
}
