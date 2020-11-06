using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGenerator : MonoBehaviour
{
    [SerializeField]
    int cardWidth, cardHeight, margin;
    [SerializeField]
    GameObject cardPrefab;
    Canvas canvas;

    public void GenerateCards(List<string> strings)
    {
        canvas = GameObject.FindObjectOfType<Canvas>();
        Vector2 topLeftPositon = new Vector2(-cardWidth / 2, -cardHeight / 2 + strings.Count / 2 * (cardHeight + margin) / 2f);
        int count = strings.Count;
        for(int i = 0; i < count/2; i++)
        {
            int rand = Random.Range(0, strings.Count);
            SpawnCard(topLeftPositon + new Vector2(-margin,  -(cardHeight + margin) * i), strings[rand]);
            strings.RemoveAt(rand);
            rand = Random.Range(0, strings.Count);
            SpawnCard(topLeftPositon + new Vector2(margin + cardWidth, -(cardHeight + margin) * i), strings[rand]);
            strings.RemoveAt(rand);
        }
        if(strings.Count>0)
            SpawnCard(topLeftPositon + new Vector2(cardWidth / 2, -(cardHeight + margin) * (count/2)), strings[0]);

    }
    void SpawnCard(Vector2 position, string text)
    {
        GameObject card = Instantiate(cardPrefab, canvas.transform);
        RectTransform rect = card.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(cardWidth, cardHeight);
        rect.anchoredPosition = position;
        card.GetComponent<Text>().text = text;
    }
}
