CREATE TRIGGER upd_qianyg_��ѧ��  ON  qianyg_ѧ���ɼ�
FOR  INSERT,UPDATE
AS
    update qianyg_ѧ��
    set qyg_����ѧ��=(
                    select sum(qyg_ѧ��) 
                    from qianyg_�γ�
                    where qyg_�γ̱�� in (
                                    select qyg_�γ̱��
                                    from qianyg_ѧ���ɼ�
                                    where qianyg_ѧ���ɼ�.qyg_�ɼ�>=60
                                          and qianyg_ѧ���ɼ�.qyg_ѧ�� in(
                                                                     select qyg_ѧ��
                                                                     from inserted 
                                                                    )
                                  )
                      )
    where qianyg_ѧ��.qyg_ѧ�� in (
                                select qyg_ѧ��  
                                from inserted
                                )
