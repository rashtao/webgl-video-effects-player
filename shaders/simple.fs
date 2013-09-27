#ifdef GL_ES
precision highp float;
#endif

uniform sampler2D sampler0;
uniform float width;
uniform float height;
uniform vec2 offset;

void main(void) {
    vec2 dim = vec2(width, height);
    vec2 p = vec2(gl_FragCoord.x, height - gl_FragCoord.y) / dim;

    gl_FragColor = texture2D(sampler0, p - offset);
}
