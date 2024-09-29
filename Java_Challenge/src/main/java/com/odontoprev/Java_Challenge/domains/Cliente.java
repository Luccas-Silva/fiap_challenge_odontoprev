package com.odontoprev.Java_Challenge.domains;

import jakarta.persistence.*;
import lombok.*;

import java.util.Date;
import java.util.List;

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
    private String cpf_cnpj;

    private String cep;
    private String tipoPlano;

    @OneToOne(cascade = CascadeType.ALL)
    private Usuario usuario;

    @OneToMany(cascade = CascadeType.ALL)
    private List<Consulta> consultas;

}
