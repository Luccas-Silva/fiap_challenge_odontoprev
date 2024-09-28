package com.odontoprev.Java_Challenge.domains;

import jakarta.persistence.*;
import lombok.*;

import java.util.Date;

@Data
@Builder
@Entity
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class Dentista  {

    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private String cpf_cnpj;
    private String cepClinica;
    private String nomeClinica;
    private String tipoClinica;
    private boolean alvaraFuncionamento;
    private String siteRedesSocial;

    @OneToOne(cascade = CascadeType.ALL)
    Usuario usuario;

}

