create table qianyg_���ڿγ�(
   qyg_�γ̱��  char(20),
   qyg_��ʦ���  char(20),
   constraint  FK_�γ�_��ʦ  foreign  key  (qyg_�γ̱��) references qianyg_�γ�,
   constraint  FK_��ʦ_�γ�  foreign  key  (qyg_��ʦ���) references qianyg_��ʦ
)