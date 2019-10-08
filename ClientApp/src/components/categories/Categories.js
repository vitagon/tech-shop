import React, { Component } from "react";
import { Container, Row, Col } from 'react-bootstrap';
import CategoriesList from './CategoriesList';

class Categories extends Component {
  render() {
    return (
      <Container>
        <Row>
          <Col md={12} className="mt-5">
            <CategoriesList></CategoriesList>
          </Col>
        </Row>
      </Container>
    );
  }
};

export default Categories;