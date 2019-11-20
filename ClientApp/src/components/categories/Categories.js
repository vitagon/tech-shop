import React, { Component } from "react";
import { Container, Row, Col } from 'react-bootstrap';
import CategoriesList from './CategoriesList';
import AddCategory from './AddCategory';
import EditCategory from './EditCategory';
import DeleteCategory from './DeleteCategory';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { TOGGLE_ADD_CATEGORY_COMP } from '../../reducers/categoriesReducer';
import { Button } from 'react-bootstrap';

class Categories extends Component {
  render() {
    return (
      <Container>
        <Row>
          <Col md={12} className="mt-5">
            <CategoriesList></CategoriesList>
            <Button block className="btn btn-success mb-3" onClick={this.props.toggleAddCategoryComp}>Add category</Button>
            {this.props.showAddCategoryComp ? (<AddCategory></AddCategory>) : null}
            {this.props.showEditCategoryComp ? (<EditCategory></EditCategory>) : null}
            <DeleteCategory></DeleteCategory>
          </Col>
        </Row>
      </Container>
    );
  }
};

const mapStateToProps = (state) => ({
  showAddCategoryComp: state.categoriesReducer.showAddCategoryComp,
  showEditCategoryComp: state.categoriesReducer.showEditCategoryComp,
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  toggleAddCategoryComp: () => (dispatch) => dispatch({ type: TOGGLE_ADD_CATEGORY_COMP, payload: false })
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Categories);