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
public class Cliente  {

    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private String cpf_cnpj;

    private String cep;
    private String tipoPlano;

    @OneToOne(cascade = CascadeType.ALL)
    Usuario usuario;

}
