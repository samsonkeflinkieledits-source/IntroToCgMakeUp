Multiple UV's: Multiple uv's allow more than one texture on a model and in my case I used this for the ground. My first texture i used was a black background and my second was red dots. It starts it two to channels for two textures. channel one includes uv--> sample texture(Takes in a texture2d)--> multiply and channel 2 takes in the same thing but with a black background and I add it to base color.

Lambert: I added this to my lava trail by adding a color to basecolor.

Rim Lighting: I added this on the trail/erupt to give that hot look to it. It works by getting the view direction and normal vector and put it in a dot product then its gets saturated and then gets put into one minus, it then gets put in a power node to control the power and I made a RimPower property so I can control without being in shader graph, I also did this for RimColor and BaseColor.


