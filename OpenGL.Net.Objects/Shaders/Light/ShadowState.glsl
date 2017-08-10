
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#ifndef GLO_SHADOW_STATE
#define GLO_SHADOW_STATE

#ifndef GLO_MAX_SHADOWS_COUNT
#define GLO_MAX_SHADOWS_COUNT			4
#endif

// Model-view-projection matrix for object-space to light-space transformation
uniform mat4 glo_ShadowMap2D_MVP[GLO_MAX_SHADOWS_COUNT];
// Shadow maps sampled using sample2D
uniform sampler2DShadow glo_ShadowMap2D[GLO_MAX_SHADOWS_COUNT];
// Number of valid sampler2DShadow in glo_ShadowMap2D
uniform int glo_ShadowMap2D_Count = 0;

#endif
