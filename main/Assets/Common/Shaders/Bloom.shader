Shader "dptr_shader/Bloom" 
{
	Properties
	{
		_MainTex ("Main Texture", 2D) = "white" {}
	}
    
    SubShader
	{
        Tags { "RenderType" = "Opaque" "Queue" = "Geometry" }
        
        Pass {
        
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			
			uniform sampler2D _MainTex;

			struct vertexInput
			{
				float4 vertex : POSITION;
				float4 texcoord : TEXCOORD0;
			};

			struct vertexOutput
			{
				float4 pos : SV_POSITION;
				float4 tex : TEXCOORD0;
			};
				
			vertexOutput vert(vertexInput input)
			{
				vertexOutput output ;

				output.tex = input.texcoord;
				output.pos = mul(UNITY_MATRIX_MVP, input.vertex);

				return output;
			}

			float4 frag(vertexOutput input) : COLOR
			{



				return tex2D(_MainTex, input.tex.xy);
			}
			
			ENDCG
        } 
    }
	
	Fallback "Diffuse"
}