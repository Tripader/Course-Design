create view qianyg_ѧ���ܳɼ���ͼ(ѧ��,����,רҵ,ѧ��,�ܳɼ�)
as
  select  qianyg_ѧ���ɼ���ͼ.ѧ��,qianyg_ѧ���ɼ���ͼ.����,qianyg_ѧ���ɼ���ͼ.רҵ,
          qianyg_ѧ���ɼ���ͼ.ѧ��,SUM(�ɼ�)
  from qianyg_ѧ���ɼ���ͼ
  group by ѧ��,����,רҵ,ѧ��
