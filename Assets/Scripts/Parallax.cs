using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _image;
    private float _imagepositionX;

    private void Start()
    {
        _image = GetComponent<RawImage>();
    }

    private void Update()
    {
        _imagepositionX += _speed * Time.deltaTime;

        if (_imagepositionX > 1)
            _imagepositionX = 0;

        _image.uvRect = new Rect(_imagepositionX, 0, _image.uvRect.width, _image.uvRect.height);
    }
}
