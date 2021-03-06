#version 330
#extension GL_ARB_separate_shader_objects : enable

layout(location=1) in vec2 fsTex;
layout(location=0) out vec4 target;

uniform sampler2D mainTex;
uniform vec4 color;
uniform float objectGlow;

void main()
{	
	vec4 mainColor = texture(mainTex, fsTex.xy);
	target = mainColor * color;
	float brightness = (target.x + target.y + target.z) / 3;
	target.xyz = target.xyz * (0.5 + objectGlow);
}