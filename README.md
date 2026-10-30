Multiple UV's: Multiple uv's allow more than one texture on a model and in my case I used this for the ground. My first texture i used was a black background and my second was red dots. It starts it two to channels for two textures. channel one includes uv--> sample texture(Takes in a texture2d)--> multiply and channel 2 takes in the same thing but with a black background and I add it to base color.

Lambert: I added this to my lava trail by adding a color to basecolor.

Rim Lighting: I added this on the trail/erupt to give that hot look to it. It works by getting the view direction and normal vector and put it in a dot product then its gets saturated and then gets put into one minus, it then gets put in a power node to control the power and I made a RimPower property so I can control without being in shader graph, I also did this for RimColor and BaseColor.


SimpleDiffusewithambient: I used this on the enemy character. I implemented it by making to property's, base Color and base texture. I added base texture into sampletexture2d(base texture --> sample texture) and then added it into multiply A and added base color into B. I then added it into base color. And  put a bronze texture on it.<img width="625" height="350" alt="image" src="https://github.com/user-attachments/assets/f7b58bda-3ecc-44c3-90f0-755a655cf36a" />
