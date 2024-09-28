package com.odontoprev.Java_Challenge.domains;

import jakarta.persistence.Entity;
import lombok.*;

@Data
@Builder
@Entity
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class Dentista extends Usuario{

    private String cepClinica;
    private String nomeClinica;
    private String tipoClinica;
    private boolean alvaraFuncionamento;
    private String siteRedesSocial;

}

