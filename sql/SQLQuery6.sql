create table qianyg_ѧ���ɼ�  (
   qyg_ѧ��  char(12),
   qyg_�γ̱��  char(20),
   qyg_��ʦ���  char(20),
   qyg_ѧ��  char(20)   NOT  NULL,
   qyg_�ɼ�  float,   
   constraint  PK_ѧ���ɼ�  primary  key  (qyg_ѧ��,qyg_�γ̱��,qyg_ѧ��),
   constraint  FK_ѧ��_ѧ���ɼ�  foreign  key  (qyg_ѧ��) references qianyg_ѧ��,
   constraint  FK_�γ̱��_ѧ���ɼ�  foreign  key  (qyg_�γ̱��) references qianyg_�γ�,
   constraint  FK_��ʦ���_ѧ���ɼ�  foreign  key  (qyg_��ʦ���) references qianyg_��ʦ
   )
