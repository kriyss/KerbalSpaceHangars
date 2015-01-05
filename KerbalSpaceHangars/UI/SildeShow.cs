/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Filename: SlideShow.cs
//  
// Author: Garth "Corrupted Heart" de Wet <mydeathofme[at]gmail[dot]com>
// Website: www.CorruptedHeart.co.cc
// 
// Copyright (c) 2010 Garth "Corrupted Heart" de Wet
//  
// Permission is hereby granted, free of charge (a donation is welcome at my website), to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;

namespace KspFR_HangarMod.UI
{
    [RequireComponent(typeof(GUITexture))]
    public class SlideShow : MonoBehaviour
    {
        public Texture2D[] Slides = new Texture2D[1];
        public float ChangeTime = 10.0f;
        private int _currentSlide = 0;
        private float _timeSinceLast = 1.0f;

        void Start()
        {
            guiTexture.texture = Slides[_currentSlide];
            guiTexture.pixelInset = new Rect(-Slides[_currentSlide].width / 2, -Slides[_currentSlide].height / 2, Slides[_currentSlide].width, Slides[_currentSlide].height);
            _currentSlide++;
        }

        void Update()
        {
            if (_timeSinceLast > ChangeTime && _currentSlide < Slides.Length)
            {
                guiTexture.texture = Slides[_currentSlide];
                guiTexture.pixelInset = new Rect(-Slides[_currentSlide].width / 2, -Slides[_currentSlide].height / 2, Slides[_currentSlide].width, Slides[_currentSlide].height);
                _timeSinceLast = 0.0f;
                _currentSlide++;
            }
            // comment out this section if you don't want the slide show to loop
            // -----------------------
            if (_currentSlide == Slides.Length)
            {
                _currentSlide = 0;
            }
            // ------------------------
            _timeSinceLast += Time.deltaTime;
        }
    }
}